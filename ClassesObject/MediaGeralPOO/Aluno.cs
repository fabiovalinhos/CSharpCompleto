namespace MediaGeralPOO
{
    public class Aluno
    {
        public string Nome { get; private set; }

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }


        public void InserirNotas()
        {
            foreach (var (value, index) in _notas.Select((value, index) => (value, index)))
            {
                Console.WriteLine($"Nota #{index}");
                _notas[index] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;

            foreach (var item in _notas)
            {
                total += item;
            }

            return total / _notas.Length;
        }
    }
}