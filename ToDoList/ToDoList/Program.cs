using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To Do List Uygulamasına Hoşgeldiniz");
            List<string> tasklist = new List<string>();
            string option = "";
            while (true)
            {
                Console.WriteLine("Ne yapmak istersiniz");
                Console.WriteLine("Görev eklemek için 1'e basın");
                Console.WriteLine("Görevi kaldırmak için 2'ye basın");
                Console.WriteLine("Listeyi görüntülemek için 3'e basın");
                Console.WriteLine("Uygulamadan çıkmak için e'ye basın");

                option = Console.ReadLine();

               if(option == "1")
                {
                   
                    Console.WriteLine("Lütfen eklemek istediğiniz görevi girin");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                  
                    Console.WriteLine("Görev listeye eklendi");
                    Console.WriteLine("*******************");

                }
              
               else if(option == "2")
                {
                  for(int i = 0; i < tasklist.Count; i++) 
                    {
                        Console.WriteLine(i + " : " + tasklist[i]);
                    }
                   
                    Console.WriteLine("Lütfen kaldırmak istediğiniz görevin numarasını girin");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);
                    Console.WriteLine("Görev kaldırıldı");
                    Console.WriteLine("*******************");
                }
               else if(option == "3")
                {
                    Console.WriteLine("Listedeki mevcut görevler : ");
                    for(int i = 0;i < tasklist.Count;i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                    Console.WriteLine("*******************");
                }
               
               else if(option == "e")
                {
                    Console.WriteLine("Uygulamadan çıkış yapılıyor");
                    Console.WriteLine("*******************");
                    break;
                }
               else
                {
                    Console.WriteLine("Yanlış seçenek,lütfen tekrar deneyin");
                }
             
            }
            Console.WriteLine("Uygulamayı kullandığınız için teşekkür ederiz!");
            

        }

    }
}
