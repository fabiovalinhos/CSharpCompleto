namespace Polimorfismo
{
    public class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {

        }

        public void Sacar()
        {

        }

        public void Saldo()
        {

        }

        public void SolicitarEmprestimo()
        {

        }
    }

    interface IConta
    {
        public string Usuario { get; set; }

        public void Depositar();

        public void Sacar();

        public void Saldo();
    }
}