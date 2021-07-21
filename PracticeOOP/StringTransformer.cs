using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP
{
    class StringTransformer    
    {
        private string name;
        private int year;
        private string str;  
        
        public StringTransformer(string strOne) 
        {
            str = strOne;    
                
        } 


        public StringTransformer (string nameOne, int yearOne) 
        {
            name = nameOne;
            year = yearOne; 
                
        }
          /*Make a function that will return a greeting statement that uses an input;
             your program should return, "Hello, <name> how are you doing today?".*/
        public void SayHi()      
        {
            Console.WriteLine($"Hello {name}");    
        
        }

        public string ReverseWords()
        {
            string[] strArray = str.Split(' ');
            Array.Reverse(strArray);
            string resalt = string.Join(' ', strArray);
            
            return resalt;
        }





    }   
}







    
            
    
    

 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     
    
    
    
    
    
    



     






