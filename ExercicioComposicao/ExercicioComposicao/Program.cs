using System.Globalization;

using ExercicioComposicao.Enums;

namespace ExercicioComposicao

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do pedido: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos items de pedido? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;i <=n; i++)
            {

                Console.WriteLine($"Entre com o # " + i + " item");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();


                Console.Write("Preço do produto: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantidade: ");
                int quatity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quatity, price, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("Sumario do Pedido: ");
            Console.WriteLine(order);

        }
    }
}
