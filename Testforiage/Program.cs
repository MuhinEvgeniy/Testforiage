using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Testforiage
{
    class Program
    {
        static void Main(string[] args)
        {

            //var company = File.Exists("Empl.json") ? JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Empl.json")) : new Company
            var company = new Company()
            /*{
                Id = new id 3,
                FirstName = "Muhin",
                LastName = "Evgeny",
                SalaryPerHour = 101
            };*/
            {
                employee = new List<Employee>()
                {
                    new Employee {
                        ID=1,
                        FirstName = "qwe",
                        LastName = "Я с инстаграммом",
                        SalaryPerHour = 123.5m
                    },
                    new Employee {
                        ID=2,
                        FirstName = "sdsa",
                        LastName = "Я на фоне заниженного таза",
                        SalaryPerHour = 121
                    }
                }
                
            };
            
            Addempl();
            //
            File.WriteAllText("Empl.json", JsonConvert.SerializeObject(company));
            
           /* var jsonUser = JsonConvert.SerializeObject(user);

            System.Console.Write(jsonUser);

            var jsonSource = "{\"id\":404,\"name\":\"Andrey\",\"first_name\":\"Andrey\",\"middle_name\":\"Alexandrovich\",\"last_name\":\"Chernikov\",\"user_name\":\"rollinx\",\"gender\":\"M\",\"email\":\"chernikov@gmail.com\",\"photo_album\":[{\"id\":1,\"name\":\"Я с инстаграммом\"},{\"id\":2,\"name\":\"Я на фоне заниженного таза\"}]}";

            var user2 = JsonConvert.DeserializeObject<User>(jsonSource);
            System.Console.ReadLine();
            string json = File.ReadAllText("Empl.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            //jsonObj["Id"] = 3;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("Empl.json", output);*/




            /*Employee Empl = new Employee
            {
                Id = 1,
                FirstName = "Muhin",
                LastName= "Evgeny",
                SalaryPerHour= 101
            };
            string jsondata = JsonConvert.SerializeObject(Employee);
            var Employee2 = JsonConvert.DeserializeObject<Employee>(jsondata);*/


            Console.ReadKey();
            
        }
        static void Addempl()
        {
        
        }
    }

    
    /* выдать запись работает
            string Employee = JsonConvert.SerializeObject(employee, Formatting.Indented);
            Console.WriteLine(Employee);
            */
}
