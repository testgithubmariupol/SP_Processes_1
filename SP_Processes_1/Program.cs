using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SP_Processes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Process p1 = new Process();
            //p1.StartInfo = new ProcessStartInfo("calc.exe");
            p1.StartInfo = new ProcessStartInfo("notepad.exe");
            //p1.StartInfo = new ProcessStartInfo("java");
            //p1.StartInfo = new ProcessStartInfo("java", "version");
            p1.Start();
            p1.WaitForExit();
            Console.WriteLine("The End");
            //Thread.Sleep(5000);
            //p1.Kill();*/


            /*//загружаем сборку
            Assembly asm = Assembly.Load(AssemblyName.GetAssemblyName("ClassLibrary1.dll"));
            //получаем необходимый модуль этой сборки
            Module mod = asm.GetModule("ClassLibrary1.dll");
            //выводим список типов данных, объявленный в текущем модуле
            Console.WriteLine("Объявленные типы данных:");
            foreach (Type t in mod.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }
            //получаем тип данных из сборки
            Type Class1Type = mod.GetType("ClassLibrary1.Class1") as Type;
            //создаём объект полученного типа данных
            object class1 = Activator.CreateInstance(Class1Type,
                new object[] { "World!" });
            //вызываем метод Print от созданного объекта
            Console.WriteLine(Class1Type.GetMethod("myMethod1").Invoke(class1, null));*/

            var result = new Surprise().getSurprise(1);

            Type resultType = result.GetType();

            //Console.WriteLine(resultType.Name);

            foreach (var item in resultType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                //Console.WriteLine(item.Name);
                //item.SetValue(result, "Petia");
                //Console.WriteLine(item.GetValue(result));
            }

            foreach (var item in resultType.GetProperties())
            {
                //Console.WriteLine(item.Name);
                //item.SetValue(result, "Sumkin");
                //Console.WriteLine(item.GetValue(result));
            }

            foreach (var item in resultType.GetMethods())
            {
                
                if (item.Name == "sayHello")
                {
                    Console.WriteLine(item.Name);
                    item.Invoke(result, null);
                }
                //Console.WriteLine(item.GetValue(result));
            }
        }
    }
}
