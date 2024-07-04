namespace Heranca
{
     class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    class Pessoa : Humano 
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    {
        // Está sealed no Pessoa
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
