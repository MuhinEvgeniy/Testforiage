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

            //var employee = File.Exists("Empl.json") ? JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Empl.json")) : new List<Employee>()
            var employee = new List<Employee>()
                {
                    new Employee {
                        ID=1,
                        FirstName = "qwe",
                        LastName = "Я",
                        SalaryPerHour = 123.5m
                    },
                    new Employee {
                        ID=2,
                        FirstName = "sdsa",
                        LastName = "Я на",
                        SalaryPerHour = 121
                    }
                };
                            
            File.WriteAllText("Empl.json", JsonConvert.SerializeObject(employee));
            Addempl();
            //
            
            Console.ReadKey();
            
        }
        static void Addempl(string firstname="", string lastname="", decimal salaryph=0)
        {

            var filePath = "Empl.json";
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var employeeList = JsonConvert.DeserializeObject<List<Employee>>(jsonData)
                                  ?? new List<Employee>();

            // Add any new employees
            employeeList.Add(new Employee()
            {
                ID = 2,
                FirstName = firstname,
                LastName = lastname,
                SalaryPerHour = salaryph
            });           

            // Update json data string
            jsonData = JsonConvert.SerializeObject(employeeList);
            System.IO.File.WriteAllText(filePath, jsonData);

        }
    }

    /* изменить запись работает
            string json = File.ReadAllText("Empl.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["employee"][0]["ID"] = 5;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("Empl.json", output);
            */
}
