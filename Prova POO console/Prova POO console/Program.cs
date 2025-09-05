using System;
using System.Collections.Generic;

namespace ControlePagamentos
{
    // Classe base
    public abstract class Pagto
    {
        public long Cpf { get; set; }
        public double Valor { get; set; }
        public int Cod { get; set; }

        public Pagto(long cpf, double valor, int cod)
        {
            Cpf = cpf;
            Valor = valor;
            Cod = cod;
        }

        public abstract double Faturar();
        public override string ToString()
        {
            return $"CPF: {Cpf} | Código: {Cod} | Valor Base: {Valor:C}";
        }
    }

    // Classe Saúde
    public class Saude : Pagto
    {
        public string Estabelecimento { get; set; }
        public double ValorSaude { get; private set; }

        public Saude(long cpf, double valor, int cod, string estabelecimento)
            : base(cpf, valor, cod)
        {
            Estabelecimento = estabelecimento;
        }

        public override double Faturar()
        {
            ValorSaude = Valor + (Valor * 0.12);
            return ValorSaude;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Estabelecimento: {Estabelecimento} | Valor Final (Saúde): {ValorSaude:C}";
        }
    }

    // Classe Alimentação
    public class Alimentacao : Pagto
    {
        public string Descricao { get; set; }
        public double ValorAlimentacao { get; private set; }

        public Alimentacao(long cpf, double valor, int cod, string descricao)
            : base(cpf, valor, cod)
        {
            Descricao = descricao;
        }

        public override double Faturar()
        {
            ValorAlimentacao = Valor + (Valor * 0.05);
            return ValorAlimentacao;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Item: {Descricao} | Valor Final (Alimentação): {ValorAlimentacao:C}";
        }
    }

    // Programa principal
    class Program
    {
        static List<Pagto> pagamentos = new List<Pagto>();

        static void Main(string[] args)
        {
            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("\n=== Sistema de Controle de Pagamentos ===");
                Console.WriteLine("1 - Cadastrar Pagamento de Saúde");
                Console.WriteLine("2 - Cadastrar Pagamento de Alimentação");
                Console.WriteLine("3 - Listar Pagamentos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarSaude();
                        break;
                    case 2:
                        CadastrarAlimentacao();
                        break;
                    case 3:
                        ListarPagamentos();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void CadastrarSaude()
        {
            try
            {
                Console.Write("Digite o CPF: ");
                long cpf = long.Parse(Console.ReadLine());

                Console.Write("Digite o valor da fatura: ");
                double valor = double.Parse(Console.ReadLine());

                Console.Write("Digite o código: ");
                int cod = int.Parse(Console.ReadLine());

                Console.Write("Digite o estabelecimento: ");
                string estabelecimento = Console.ReadLine();

                Saude s = new Saude(cpf, valor, cod, estabelecimento);
                s.Faturar();
                pagamentos.Add(s);

                Console.WriteLine("Pagamento de Saúde cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        static void CadastrarAlimentacao()
        {
            try
            {
                Console.Write("Digite o CPF: ");
                long cpf = long.Parse(Console.ReadLine());

                Console.Write("Digite o valor da fatura: ");
                double valor = double.Parse(Console.ReadLine());

                Console.Write("Digite o código: ");
                int cod = int.Parse(Console.ReadLine());

                Console.Write("Digite a descrição do item: ");
                string descricao = Console.ReadLine();

                Alimentacao a = new Alimentacao(cpf, valor, cod, descricao);
                a.Faturar();
                pagamentos.Add(a);

                Console.WriteLine("Pagamento de Alimentação cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        static void ListarPagamentos()
        {
            Console.WriteLine("\n=== Histórico de Pagamentos ===");
            if (pagamentos.Count == 0)
            {
                Console.WriteLine("Nenhum pagamento cadastrado.");
                return;
            }

            foreach (var p in pagamentos)
            {
                Console.WriteLine(p);
            }
        }
    }
}

