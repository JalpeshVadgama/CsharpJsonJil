using Jil;
using System;
using System.IO;

namespace CsharpJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = GetEmployee();
            string employeeSerializedString = SerializeEmployee(employee);

            Console.WriteLine("Serialize Employee");
            Console.WriteLine(employeeSerializedString);

            Console.WriteLine("\n\nDeserializing Employee");
            var employeeDeserialized = DeserializeEmployee(employeeSerializedString);

            Console.WriteLine(employeeDeserialized.EmployeeId);
            Console.WriteLine(employeeDeserialized.FirstName);
            Console.WriteLine(employeeDeserialized.LastName);
            Console.WriteLine(employeeDeserialized.Designation);

            Console.ReadKey();
        }

        private static Employee GetEmployee()
        {
            var employee = new Employee
            {
                EmployeeId = 1,
                FirstName = "Jalpesh",
                LastName = "Vadgama",
                Designation = "Technial Architect"
            };
            return employee;
        }

        private static string SerializeEmployee(Employee employee)
        {
            using (var output = new StringWriter())
            {
                JSON.Serialize(
                   employee,
                    output
                );
                return output.ToString();
            }
        }

        private static Employee DeserializeEmployee(string employeeString)
        {
            return JSON.Deserialize<Employee>(employeeString);
        }




    }
}
