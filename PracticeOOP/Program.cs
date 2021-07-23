using System;
using PracticeOOP; 

namespace PracticeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string teacherNameMain = "Elbek Normurodov";
            int teacherYearsMain = 21;


            StringTransformer myObjOne = new StringTransformer (teacherNameMain, teacherYearsMain);

            Console.WriteLine($"My teacher name {teacherNameMain}. Hi is {teacherYearsMain} years old");
             
            StringTransformer myObjTwo = new StringTransformer (teacherNameMain);

            string resultMain = myObjTwo.ReverseWords();

            Console.WriteLine(resultMain);

            







        }
    }
}
