
namespace SistemaHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int quantidadeHospedes = hospedes.Count;
            int capacidade = Suite.Capacidade;

            if (capacidade >= quantidadeHospedes)
            {
                Hospedes = hospedes;
                Console.WriteLine("Cadastro de Hospedes!");
            }
            else
            {
                //obs.: analisar outra exceção
                throw new Exception("Exceção: a quantidade de hospedes é maior que a capacidade.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
            Console.WriteLine("Suíte cadastrada com sucesso!");
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;

            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria(Suite suite)
        {
            decimal valor = 0;

            valor = DiasReservados * Suite.ValorDiaria;

            decimal percentual = 0.1M;

            if (DiasReservados >= 10)
            {
                valor -= (decimal)(valor * percentual);
            } 

            return valor;
        }
    }
}