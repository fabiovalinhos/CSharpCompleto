namespace List
{
    public class Lista
    {

        public string[] nomes = new string[3];
        public List<string> nomes2 = new();

        public void Acionando()
        {
            nomes2.Clear();

            nomes[0] = "Gabriel";
            nomes[1] = "Bruce";
            nomes[2] = "Danny";

            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes);

            //if (nomes2.Remove("Lucas"))
            //{
            //    Console.WriteLine("Lucas removido");
            //}
            //else
            //{
            //    Console.WriteLine("Não foi possível remover");
            //}

            //if (nomes2.Contains("Danny"))
            //{
            //    Console.WriteLine("Contêm o elemento");
            //}
            //else
            //{
            //    Console.WriteLine("Não contêm");
            //}

            //Console.WriteLine($"Número de elementos {nomes2.Count}"); 

            //nomes2.Sort();

            //Console.WriteLine($"O indíce do Gabriel é {nomes2.IndexOf("Gabriel")}");

            nomes2.Insert(2, "João");
            nomes2.RemoveAt(2);
        }
    }
}