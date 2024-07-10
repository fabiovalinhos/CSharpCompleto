namespace Dictionary
{
    public class ClasseDictionary
    {
        public Dictionary<int, string> alunos = new()
        {
            { 150,"Danny"},
            { 200, "Arthur"},
            { 80, "Danny"}
        };

        public void Acionando()
        {
            alunos.Add(100, "Gabriel");

            //var res = alunos.Count();
            //var res = alunos.Remove(100);
            //var res = alunos.Clear();
            var res = alunos.ContainsKey(70);
            //var res = alunos.ContainsValue("Jonas");
            //var res = alunos.First().Value;
            //var res = alunos.Last();

            Console.WriteLine($"Teste de saida {res}");
            Console.WriteLine();
        }
    }
}
