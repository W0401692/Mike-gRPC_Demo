using Grpc.Core;
using Mikesgrpcdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mikesgrpcdemo.MikesGrpcDemo;

namespace MikesGrpcDemoClient
{
    class MikesGrpcDemoClient
    {

        readonly MikesGrpcDemo.MikesGrpcDemoClient client;


        public MikesGrpcDemoClient(MikesGrpcDemo.MikesGrpcDemoClient client)
        {
            this.client = client;
        }


        static void Main(string[] args)
        {
            //Create the channel and client
            var channel = new Channel("127.0.0.1:50052", ChannelCredentials.Insecure);
            var client = new MikesGrpcDemoClient(new MikesGrpcDemo.MikesGrpcDemoClient(channel));

            //Get Contact Info - Simple RPC 
            client.GetTheContactInfo();          

            // Get Groceries - Server-side Streaming
            client.GetSomeGroceries().Wait();

            // Stop the client
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
       

        // Calls the GetContactInfo method of the service 
        public void GetTheContactInfo()
        {
            // Create the request message
            Name request = new Name { Name_ = "Mike Robinson" };
            // Receive the response message
            ContactInfo reply = client.GetContactInfo(request);

            Console.WriteLine(reply.Name + "\n" + reply.Email + "\n" + reply.PhoneNum + "\n");
        }


        // Calls the GetGroceries method of the service
        public async Task GetSomeGroceries()
        {
            // Create the request message
            GroceryRequest req = new GroceryRequest { Items = 4 };

            // Receive the response stream (uses AsyncServerStreamingCall object)
            using (var call = client.GetGroceries(req))
            {
                int count = 0;

                while (await call.ResponseStream.MoveNext())
                {
                    count++;
                    GroceryResponse item = call.ResponseStream.Current;
                    Console.WriteLine("Item " + count + ": " + item.Grocery + "\n");
                }
            }
        }

    }
}
