using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{        
    public class Student
    {
        private string name = null;
        private string surname = null;
        private string thirdname = null;
        private readonly string id;
        private readonly string FakNom;
        int studentcounter;


        public Student(string id, string FakNom)
    {
        // TODO: Complete member initialization 
            this.id = id;
            this.FakNom = FakNom;
            this.name = name;
            this.surname = surname;
            this.thirdname = thirdname;
            FakNom = GenerateFakNom();  
            int ocenka1; 
            int ocenka2;
            this.studentcounter = studentcounter+1;
    }

         public string Id
         {
             get { return id; }
         }

         private string GenerateFakNom()
         {
             return null;
         }
        private void AddInfo()
        {
        }
        private void Setid(string id)
        {
            //this method validates all the numbers of the ID
            //and sets the ID if they are valid
            //else it throws an exception
        }

      //  class Student
      //  {
            static void Main(string[] args)
            {
                
                Student firststudent=new Student("id", "FakNom");
                firststudent.name = "Ivan";
                firststudent.thirdname = "Petrov";
                firststudent.ocenka1 = 4;
                firststudent.ocenka2 = 3;
                
                Console.Write(studentcounter);
                //string Id;
                //string GenerateFakNom;
                //string name = Console.ReadLine();
                //string surname = Console.ReadLine();
                //string thirdname = Console.ReadLine();

        }

      
    
 //   }
    }
}
