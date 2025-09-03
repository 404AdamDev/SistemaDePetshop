using System;
using System.Threading;
using System.Collections.Generic;

namespace SistemaPetShop
{
    public class Animal
    {
        public string NomeAN { get; set; }
        public int IdadeAN { get; set; }
        public Animal(string nomeAN, int idadeAN) { NomeAN = nomeAN; IdadeAN = idadeAN; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som... Animal...");
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"+-+-+-+-+ Infos do Animal +-+-+-+-+\nNome: {this.NomeAN}\nIdade: {this.IdadeAN}");
        }
    }

    public class Cachorro : Animal
    {
        public string RacaAN { get; set; }
        public Cachorro(string nomeAN, int idadeAN, string racaAN) : base(nomeAN, idadeAN) { RacaAN = racaAN; }

        public override void EmitirSom()
        {
            Console.WriteLine("\nAu! Au!");
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"+-+-+-+-+ Infos do Animal +-+-+-+-+\nNome: {this.NomeAN}\nIdade: {this.IdadeAN}\nRaça: {this.RacaAN}");
        }
    }

    public class Gato : Animal
    {
        public string CorAN { get; set; }
        public Gato(string nomeAN, int idadeAN, string corAN) : base(nomeAN, idadeAN) { CorAN = corAN; }

        public override void EmitirSom()
        {
            Console.WriteLine("\nMiau!");
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"+-+-+-+-+ Infos do Animal +-+-+-+-+\nNome: {this.NomeAN}\nIdade: {this.IdadeAN}\nCor: {this.CorAN}");
        }
    }

    public class Papagaio : Animal
    {
        public Papagaio(string nomeAN, int idadeAN, string corAN) : base(nomeAN, idadeAN) { }

        public override void EmitirSom()
        {
            Console.WriteLine("\nCurupaco!");
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"+-+-+-+-+ Infos do Animal +-+-+-+-+\nNome: {this.NomeAN}\nIdade: {this.IdadeAN}");
        }
    }

    public class PetShop
    {
        private List<Animal> AnimaisCADS = new List<Animal>();
        public void AdicionarAnimal(Animal animal)
        {
            AnimaisCADS.Add(animal);
            Console.WriteLine($"\nAnimal '{animal.NomeAN}' adicionado com sucesso!");
        }

        public void ListarAnimais()
        {
            if (AnimaisCADS.Count == 0)
            {
                Console.WriteLine("\nOhh... que pena! Parece que nenhum animal foi adicionado no sistema ainda!");
                return;
            }

            Console.WriteLine("\n--------- Lista de Animais ---------");
            foreach (var animal in AnimaisCADS)
            {
                animal.ExibirInfo();
                animal.EmitirSom();
            }
        }

        public double MediaIdade()
        {
            if (AnimaisCADS.Count == 0) return 0;
            double soma = 0;
            foreach (var animal in AnimaisCADS)
                soma += animal.IdadeAN;

            return soma / AnimaisCADS.Count;
        }
    }

    class Program
    {
        static PetShop loja = new PetShop();
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            Thread.Sleep(2000);
            mainMenu();
        }

        public static void mainMenu()
        {

            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("~~~~~~~~~~~~ Pet Shop ~~~~~~~~~~~~");
                Console.WriteLine("Bem vindo ao PetShop!\nNeste sistema você pode gerenciar os animais da nossa loja física.\nEntão... Qual tipo de animal está pensando em cadastrar?\n(se não estiver pensando em nenhum, então pressione enter...) (o texto em parênteses é o texto que precisa ser selecionado para a opção ser identificada)");
                Console.Write("\n>>> Adicionar Animal (adicionar)\n>>> Dados PetShop (dados)\nSua escolha: ");
                option = (Console.ReadLine() ?? "nenhum").ToLower();

                if (option == "nenhum" && option != "") { break; }
                switch (option)
                {
                    case "adicionar":
                        AddAnimal();
                        break;
                    case "dados":
                        MostrarAnimais();
                        break;
                }

            } while (option != "nenhum" && option != "");

            Console.WriteLine("\nEncerrando...");
        }

        public static void AddAnimal()
        {
            loja.AdicionarAnimal(new Cachorro("Rex", 3, "Pastor Alemão"));
            loja.AdicionarAnimal(new Gato("Mimi", 2, "Branco"));
            loja.AdicionarAnimal(new Papagaio("Loro", 5, "Bom dia!"));

            Console.WriteLine("\nDeseja cadastrar um novo animal? (s/n)");
            string resp = (Console.ReadLine() ?? "n").ToLower();
            while (resp == "s")
            {
                Console.Write("\nQual tipo de animal? (cachorro/gato/papagaio): ");
                string tipo = (Console.ReadLine() ?? "cachorro").ToLower();

                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "Sem nome";

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine() ?? "1");

                if (tipo == "cachorro")
                {
                    Console.Write("Raça: ");
                    string raca = Console.ReadLine() ?? "Sem raça";
                    loja.AdicionarAnimal(new Cachorro(nome, idade, raca));
                }
                else if (tipo == "gato")
                {
                    Console.Write("Cor: ");
                    string cor = Console.ReadLine() ?? "Branco";
                    loja.AdicionarAnimal(new Gato(nome, idade, cor));
                }
                else
                {
                    Console.WriteLine("Tipo inválido, tente novamente.");
                }

                Console.Write("\nDeseja cadastrar outro animal? (s/n): ");
                resp = (Console.ReadLine() ?? "n").ToLower();
            }

            Console.WriteLine("\nVoltando ao menu...");
            mainMenu();
        }

        public static void MostrarAnimais()
        {
            Console.WriteLine("\nLista atualizada de animais:");
            loja.ListarAnimais();

            Console.WriteLine("\nDeseja voltar ao menu? (s/n)");
            string resp = (Console.ReadLine() ?? "n").ToLower();

            if (resp == "s")
                mainMenu();
        }
    }
}