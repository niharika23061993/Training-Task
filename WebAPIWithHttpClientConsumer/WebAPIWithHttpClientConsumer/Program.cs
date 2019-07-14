using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
//using System.Net.Http.Formatting;
namespace WebAPIWithHttpClientConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient cons = new HttpClient();
            cons.BaseAddress = new Uri("http://localhost:7967/");
            cons.DefaultRequestHeaders.Accept.Clear();
            cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));            
            
           // MyAPIPut(cons).Wait();
            //MyAPIDelete(cons).Wait();
           MyAPIPost(cons).Wait();
        }
        static async Task MyAPIPut(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("api/Employees/4");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    Employee Emp = await res.Content.ReadAsAsync<Employee>();
                    Emp.EmpName = "Merry";
                    Emp.EmpRole = "business analyst";
                    res = await cons.PutAsJsonAsync("api/Employees/4", Emp);
                   
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("Put Operation");
                    Console.WriteLine("\n");
                    Console.WriteLine("EmpId    EmpName          EmpRole");
                    Console.WriteLine("{0}\t{1}\t\t{2}", Emp.EmpId, Emp.EmpName, Emp.EmpRole);
                    Console.WriteLine("\n");
                    
                    

                    Console.ReadLine();
                }
            }
        }
        static async Task MyAPIDelete(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("api/Employees/4");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    res = await cons.DeleteAsync("api/Employees/4");
                    Console.WriteLine("\n");
                    Console.WriteLine(" Delete Operation Completed successfully");
               
                    Console.ReadLine();
                }
            }
        }
        
        static async Task MyAPIPost(HttpClient cons)
        {
            using (cons)
            {
                var tag = new Employee { EmpName = "Megan", EmpRole = "Sr.Developer" };
                HttpResponseMessage res = await cons.PostAsJsonAsync("api/Employees", tag);
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Post Operation Created Successfully");
                    Console.ReadLine();
                }
            }
        }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpRole { get; set; }
    }
}
