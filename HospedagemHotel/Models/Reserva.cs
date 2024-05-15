namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try
            {
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Suite não suporte o número de hóspedes desejado.");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
                decimal calculaDiarias = Suite.ValorDiaria * DiasReservados;
                valor = Math.Round(calculaDiarias * 0.9m, 2);
            }

            return valor;
        }
    }
}