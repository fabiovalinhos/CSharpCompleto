namespace HashSet
{
    public class ClasseHashSet
    {
        public HashSet<string> veiculos = new()
        {
            "Carro",
            "Moto",
            "Avião",
            "Helicoptero",
            "Barco"
        };

        public void Acionando()
        {
            veiculos.Add("Veículo Adicionado");

            if (veiculos.Add("Cavalo"))
            {
                Console.WriteLine("Cavalo adicionado");
            }
            else
            {
                Console.WriteLine("Item não adionado");
            }

            if (veiculos.Add("Moto"))
            {
                Console.WriteLine("Moto adicionado");
            }
            else
            {
                Console.WriteLine("Moto não adionado");
            }

            if (veiculos.Contains("Carro"))
            {
                Console.WriteLine("Esta lista contêm carro");
            }
            else
            {
                Console.WriteLine("Não contêm carro");
            }

            //veiculos.Remove("");
            //veiculos.Count;
            //veiculos.Clear();
            //veiculos.First();
            //veiculos.Last();

            Console.WriteLine(
                $"Buscando o indice 2 na hashSet -> {veiculos.ElementAt(2)}");
        }
    }
}
