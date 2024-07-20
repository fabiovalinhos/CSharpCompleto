using System.Security.Cryptography;

namespace LINQ_1
{
    public class AcoesLinq
    {
        List<string> lista_nomes;

        List<int> lista_numeros;

        Dictionary<string, double> lista_produtos;

        Dictionary<string, string> lista_estados;

        public AcoesLinq()
        {
            #region Lista de nomes
            lista_nomes =
            [
                "Márcio",
                "Adalto",
                "Fábio",
                "Renato",
                "Marcelo",
                "Rodrigo",
                "Renam",
                "Lindalva",
                "Frederico",
                "Arildo"
            ];
            #endregion 

            #region Lista de números
            lista_numeros =
            [3, 7, 12, 19, 23, 34, 45, 56, 67, 78, 81, 92, 105, 117, 130, 142, 155, 168, 179, 183, 195, 207, 219, 230, 245]
;
            #endregion

            #region Lista de produtos
            lista_produtos = new()
        {
            { "Teclado Mecânico", 150.00 },
            { "Mouse Gamer", 75.00 },
            { "Monitor 24\"", 350.00 },
            { "Gabinete ATX", 120.00 },
            { "Fonte 650W", 200.00 },
            { "Placa-Mãe", 450.00 },
            { "Processador", 800.00 },
            { "Memória RAM 16GB", 120.00 },
            { "SSD 512GB", 90.00 },
            { "HDD 1TB", 50.00 },
            { "Placa de Vídeo", 1200.00 },
            { "Cooler CPU", 60.00 },
            { "Fone de Ouvido", 100.00 },
            { "Webcam HD", 70.00 },
            { "Mousepad", 25.00 }
        };
            #endregion

            #region Lista de estados
            lista_estados = new Dictionary<string, string>
{
    { "Califórnia", "Estados Unidos" },
    { "Quebec", "Canadá" },
    { "Baviera", "Alemanha" },
    { "Nova Gales do Sul", "Austrália" },
    { "Maharashtra", "Índia" },
    { "São Paulo", "Brasil" },
    { "Ontário", "Canadá" },
    { "Karnataka", "Índia" },
    { "Rio de Janeiro", "Brasil" },
    { "Flórida", "Estados Unidos" },
    { "Hokkaido", "Japão" },
    { "Sichuan", "China" },
    { "Catalunha", "Espanha" },
    { "Lombardia", "Itália" },
    { "Île-de-France", "França" },
    { "Gauteng", "África do Sul" },
    { "Valência", "Espanha" },
    { "Queensland", "Austrália" },
    { "Alberta", "Canadá" },
    { "Calábria", "Itália" },
    { "Texas", "Estados Unidos" },
    { "British Columbia", "Canadá" },
    { "Saxônia", "Alemanha" },
    { "Vitória", "Austrália" },
    { "Uttar Pradesh", "Índia" },
    { "Minas Gerais", "Brasil" },
    { "Manitoba", "Canadá" },
    { "Tamil Nadu", "Índia" },
    { "Bahia", "Brasil" },
    { "Nevada", "Estados Unidos" },
    { "Osaka", "Japão" },
    { "Hunan", "China" },
    { "Andaluzia", "Espanha" },
    { "Lácio", "Itália" },
    { "Nouvelle-Aquitaine", "França" }
};

            #endregion
        }

        public void MetodoParaLinq()
        {
            IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            foreach (var item in res)
            {
                Console.WriteLine($"Da lista de número eu obtenho: {item}");
            }
        }

        public void MetodoString()
        {
            IEnumerable<string> resultado = from nome in lista_nomes where nome.StartsWith("M") select nome;

            foreach (var item in resultado)
            {
                Console.WriteLine($"Nome escolhido: {item}");
            }
        }

        public void OperadorWhere()
        {
            var retorno = from nome in lista_nomes
                          where nome.ToLower().Contains("l")
                          select nome;

            foreach (var item in retorno)
            {
                Console.WriteLine($"Nome escolhido no whereß: {item}");
            }
        }

        public void OperadorOrdenacao()
        {
            var res = from num in lista_numeros
                      orderby num descending
                      where num <= 30
                      select num;

            foreach (var num in res)
            {
                Console.WriteLine($"Numero na ordem {num}");
            }

            Console.WriteLine(" -- ");

            var resNomes = from nome in lista_nomes
                           orderby nome descending
                           select nome;

            foreach (var nome in resNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine(" -- ");

            var resDictionary = from produto in lista_produtos
                                orderby produto.Key descending
                                select produto;

            foreach (KeyValuePair<string, double> item in resDictionary)
            {
                Console.WriteLine($"chave {item.Key} - R${item.Value}");
            }

        }


        public void OperadorGroupBy()
        {
            //Operadores de agrupamento

            var res = from estado in lista_estados
                      group estado by estado.Value;

            foreach (var grupo in res)
            {
                Console.WriteLine($"Nome do grupo {grupo.Key}");
                foreach (var estado in grupo)
                {
                    Console.WriteLine($"Valor de cada estado dentro de cada grupo {estado.Key}");
                }
                Console.WriteLine("");
            }
        }
    }
}