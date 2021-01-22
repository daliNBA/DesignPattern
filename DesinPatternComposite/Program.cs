using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPatternComposite
{
    public class Client
    {
        public void ClientCode(Delivery leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }
        public void ClientCode(Delivery delivery1, Delivery delivery2)
        {
           if(delivery1.IsComposite())
            {
                delivery1.Add(delivery2);
            }
            Console.WriteLine($"RESULT: {delivery1.Operation()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Product product = new Product();
            client.ClientCode(product);

            Box tree = new Box();
            Box branch1 = new Box();
            branch1.Add(new Product());
            branch1.Add(new Product());
            Box branch2 = new Box();
            branch2.Add(new Product());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode(tree, branch1);

        }
    }
}
