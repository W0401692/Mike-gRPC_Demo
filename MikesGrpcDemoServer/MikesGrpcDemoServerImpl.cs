using Grpc.Core;
using Mikesgrpcdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikesGrpcDemoServer
{
    public class MikesGrpcDemoServerImpl : MikesGrpcDemo.MikesGrpcDemoBase // Inherits from the generated base class
    {

        // Implementation of the GetContactInfo service method 
        public override async Task<ContactInfo> GetContactInfo(Name request, ServerCallContext context)
        {
            // Hard coded data - could come from a db or other service I suppose
            string name = "Mike Robinson";
            string email = "mike@example.com";
            string phoneNum = "902-555-1234";

            // Create the response message
            ContactInfo contact = new ContactInfo { Name = name, Email = email, PhoneNum = phoneNum };

            // return the response
            return await Task.FromResult(contact);
        }


        // Implementation of the GetGroceries service method
        public override async Task GetGroceries(GroceryRequest request, IServerStreamWriter<GroceryResponse> responseStream, ServerCallContext context)
        {
            // Hard coded data
            List<string> groceries = new List<string> { "Potatoes", "Chicken", "Strawberries", "Milk", "Crackers", "Ice Cream", "Olives", "Lobster", "Orange Juice" };            

            // Return stream of reponse messages - one message for each item in the list
            foreach (var item in groceries)
            {
                GroceryResponse reply = new GroceryResponse { Grocery = item };
                await responseStream.WriteAsync(reply);
            }
        }
    
    }
}
