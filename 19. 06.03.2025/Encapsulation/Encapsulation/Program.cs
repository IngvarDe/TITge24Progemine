using Encapsulation.Service;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapseldamine");

            Student student = new Student();

            //kui class on internal ja asub teises libarys e teegis,
            //siis ei saa kasutada seda
            //Student2 student2 = new Student2();

            student.Id = 101;
            student.Name = "Test";
            student.Email = "Test@Test.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);

            //kasutame protected classi
            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.DoSomething();
            //protectedStudent.DoSomething();
            //kui DoSomething on protected ja teises classis,
            //siis ei saa seda kasutada

            Console.WriteLine("-----------DoSomethingInProgramClass-------------");
            Program program = new Program();
            program.DoSomethingInProgramClass();
            //samas classis olevat protected meetodit saab esile kutsuda

            Console.WriteLine("-----------Private protected---------------");
            Program pp = new Program();
            Console.WriteLine(pp.PrivateProtectedInProgramClass
                = "PrivateProtectedInProgramClass");

            var privateProtectedStudent = new PrivateProtectedStudent();
            //alumine rida anna errorit
            //privateProtectedStudent.PrivateProtectedStudent1 = "asdasdasd";

            Console.WriteLine("-----------Sealed class------------------");
            //sealed classi kasutamine
            var sc = new SealedClass();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "Test@test.com";
            Console.WriteLine($"Id on {sc.Id}, name on {sc.Name} ja email on {sc.Email}");
        }

        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }

        private protected string PrivateProtectedInProgramClass =
            "PrivateProtectedInProgramClass";
    }
}
