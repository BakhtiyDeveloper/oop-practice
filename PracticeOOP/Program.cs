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
            
            myname.SayHi(); 
             
             
            
        
        }
    }
}
