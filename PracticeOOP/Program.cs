using System;
using PracticeOOP; 

namespace PracticeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string mynamePro = "Bahtiyor";
            int myyearPro = 34;
            

            StringTransformer myname = new StringTransformer(mynamePro, myyearPro);
           
            StringTransformer myObj = new StringTransformer("Elbek Ustoz");

            string resultMain = myObj.ReverseWords();

            Console.WriteLine(resultMain);

            
             
            
        
        }
    }
}
