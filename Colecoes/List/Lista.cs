namespace List
{
    public class Lista
    {

        public string[] nomes = new string[3];
        public List<string> nomes2 = new();

        public void Acionando()
        {
            nomes[0] = "Gabriel";
            nomes[1] = "Bruce";
            nomes[2] = "Danny";

            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes);
        }
    }
}