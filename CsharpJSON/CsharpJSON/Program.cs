
using Jil;
using System.IO;

namespace CsharpJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = GetEmployee();
            string employeeSerializedString = SerializeEmployee(employee);



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

        static Employee GetEmployee()
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
    }
}
