using Grpc.Core;
using Mikesgrpcdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikesGrpcDemoServer
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare the port the server will listen on
            const int Port = 50052;                

            // Instance the server
            Server server = new Server
            {
                // Bind the service implementation to the server 
                Services = { MikesGrpcDemo.BindService(new MikesGrpcDemoServerImpl()) },

                // Assign the address and port to the server - note: Insecure implementation -> no authorization
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };

            // start the server
            server.Start();


            Console.WriteLine("Mike's Demo Server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();
            
            // shutdown the server
            server.ShutdownAsync().Wait();
        }
    }
}
