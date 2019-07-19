using System;
using Nancy;
using Nancy.ModelBinding;

namespace C_Sharp_REST
{

    public class UserModule : NancyModule
    {

        private User[] users = new User[]
        {
            new User { id = 1, name = "John", email = "John@infomail.com", phone = "0 111", role = 1 },
            new User { id = 2, name = "Mike", email = "Mike@infomail.com", phone = "0 222", role = 1 },
            new User { id = 3, name = "Smith", email = "Smith@infomail.com", phone = "0 333", role = 1 },
        };

        public UserModule() : base("/user")
        {
            Get("/json", _ =>
            {
                Console.WriteLine("Get json");
                return Response.AsJson(users);
            });

            Get("/xml", _ =>
            {
                Console.WriteLine("Get xml");
                return Response.AsXml(users);
            });

            Get("/{userid:int}", _ =>
            {
                int uId = _.userid;
                Console.WriteLine("Get by id : " + uId);
                return Response.AsText("");
            });

            Post("/", _ =>
            {
                User user = this.Bind<User>();
                Console.WriteLine("adding user : " + user);                
                return Response.AsText("Added user");
            });

            Put("/{userid:int}", _ =>
            {
                int uId =_.userid;
                Console.WriteLine("updating user : " + uId);
                return Response.AsText("Updated user uId");
            });

            Delete("/{userid:int}", _ =>
            {
                int uId = _.userid;
                Console.WriteLine("deleting user : " + uId);
                return Response.AsText("Deleted user uId");                
            });
        }
    }
}
