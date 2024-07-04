namespace Modificadores
{
    class Teste
    {
        private string nome;
        
        public string sobrenome;

        private void Metodo1()
        {

        }

        public void Executar()
        {

        }
    }

    class Humano
    {
        protected string nome;

        private string sobrenome;

        // se for criado uma dll desta classe este internal
        // exclusivamente dela
        //disponível ao mesmo assembly, desta aplicação
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = string.Empty;
            idade = 0;
        }
    }
}
