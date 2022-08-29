using System;
using System.IO;
using System.Security.Cryptography;

namespace Aula
{
    class Program

    {
        static void Cadastrar(string username,string password){
            string usuarios=File.ReadAllText("cadastro.txt");
    string[]linhas=usuarios.Split("\n");
    bool existe=false;
    foreach(string linha in linhas){
        string[]conteudo=linha.Split("=");
        if(conteudo[0]==username){
            existe=true;
            break;

        }
        if(existe){
            Console.WriteLine("Usuario ja cadastrado");

        }
        else {
            File.AppendAllText("cadastro.txt",username+"="+password);
            Console.WriteLine("Cadastro ja efetuado");
        }
    }
            //TO DO verifoicar se user ja existe 
            usuarios+="\n"+username+"="+password;
            File.WriteAllText("cadastro.txt",usuario);
            File.AppendAllText("cadastro.txt",username+"=")
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");
            Console.WriteLine("DIGITE 1 PARA CADASTRAR");
            Console.WriteLine("DIGITE 2 PARA LOGIN");
            Console.WriteLine("DIGITE 3 PARA SAIR");
            bool sair = false;
            while (!sair)
            {
                var opcao = 0;
                try
                {
                    opcao = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {

                }

                switch (opcao)
                {
                    case 1:
                        Cadastrar();

                        break;
                  
                    Console.WriteLine("Digite um nome de usuário");;
                    string username=Console.ReadLine();
                     Console.WriteLine("Digite uma senha");;
                    string password=Console.ReadLine();
                    Console.WriteLine("Confirme a senha");;
                    string confirmacao=Console.ReadLine();
                    if(password!=confirmacao)
                    {
                        Console.WriteLine("a senha não confere");
                    }
                    else{
                        Cadastrar(username,password);
                    }
  case 2:
                        logar();
                        break;
                    case 3:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("opção inválida tente novamente!");
                        break;
                }

            }


        }
    }
}
