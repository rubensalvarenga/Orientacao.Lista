namespace Orientacao.Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamentos = new List<Pagamento>();

            pagamentos.Add(new Pagamento(1,"caneta bic 1", "Rubens"));
            pagamentos.Add(new Pagamento(2, "caneta bic 2", "Rubens"));
            pagamentos.Add(new Pagamento(3, "caneta bic 3", "Rubens"));
            pagamentos.Add(new Pagamento(4, "caneta bic 4", "Rubens"));
            pagamentos.Add(new Pagamento(5, "caneta bic 5", "Rubens"));
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Lista de Pagamentos PAGOS - usando o Add");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            foreach (var item in pagamentos)
            {
                
                Console.Write("ID : "+item.Id +" | ");
                Console.Write("DESCRIÇÃO : "+item.Descricao + " | ");
                Console.Write("PESSOA RESPONSAVEL : "+item.Pessoa + " | ");
                Console.WriteLine("");
                Console.WriteLine("===========================================================================");
            }

            var pagamentosPago = new List<Pagamento>();
            Console.WriteLine("");
            pagamentosPago.AddRange(pagamentos);
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Lista de Pagamentos PAGOS - usando o AddRange");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------");
            foreach (var pagamentoPago in pagamentosPago)
            {
                
                Console.Write("ID : " + pagamentoPago.Id + " | ");
                Console.Write("DESCRIÇÃO : " + pagamentoPago.Descricao + " | ");
                Console.Write("PESSOA RESPONSAVEL : " + pagamentoPago.Pessoa + " | ");
                Console.WriteLine("");
                Console.WriteLine("===========================================================================");

            }


            var pesquisa = pagamentosPago.Where(x => x.Id > 3);
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Lista de Pagamentos where e first");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------");
            foreach(var pesquisaPago in pesquisa)
            {
                Console.Write("ID : " + pesquisaPago.Id + " | ");
                Console.Write("DESCRIÇÃO : " + pesquisaPago.Descricao + " | ");
                Console.Write("PESSOA RESPONSAVEL : " + pesquisaPago.Pessoa + " | ");
                Console.WriteLine("");
                Console.WriteLine("===========================================================================");
            }

            var pesquisaFirst = pagamentosPago.First( x=> x.Id == 3);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("FIRST -> ID : " + pesquisaFirst.Id + " | ");
            Console.Write("DESCRIÇÃO : " + pesquisaFirst.Descricao + " | ");
            Console.Write("PESSOA RESPONSAVEL : " + pesquisaFirst.Pessoa + " | ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Removendo 1 e pulando 1");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------");
           
            var pagamentoRemove = new List<Pagamento>();

            pagamentoRemove.AddRange(pagamentos);

            pagamentoRemove.Remove(pesquisaFirst);

            foreach (var removeItem in pagamentoRemove.Skip(1))
            {
                Console.Write("ID : " + removeItem.Id + " | ");
                Console.Write("DESCRIÇÃO : " + removeItem.Descricao + " | ");
                Console.Write("PESSOA RESPONSAVEL : " + removeItem.Pessoa + " | ");
                Console.WriteLine("");
                Console.WriteLine("===========================================================================");
            }
        }
    }

    public class Pagamento {

        public Pagamento(int id, string descricao, string pessoa)
            {
            Id = id;
            Descricao = descricao;
            Pessoa = pessoa;

            }
        public int Id { get; set; }
        public string Descricao { get; set;}
        public string Pessoa { get; set;}

        
    }
}