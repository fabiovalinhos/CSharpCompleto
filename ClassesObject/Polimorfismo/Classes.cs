namespace Polimorfismo
{
   abstract public class Forma
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public int Altura { get; set; }

        public int Largura { get; set; }

        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        //public abstract void Area() { } // a classe precisa ser abstract

        public virtual void Area()
        {
            double area = Altura * Largura;
            Console.WriteLine($"Área {area}");
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Circulo");
            base.Desenhar();
        }

        public override void Area()
        {

            double area = 3.14 * Math.Pow(Raio, 2);
            Console.WriteLine($"Área do circulo é {area}");
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Retangulo");
            base.Desenhar();
        }

        public override void Area()
        {
            base.Area();            
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Triangulo");
            base.Desenhar();
        }

        public override void Area()
        {

            double area = (Largura * Altura) / 2;
            Console.WriteLine($"Área do triângulo é {area}");
        }
    }
}
