using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP
{
    class StringTransformer    
    {
        string name;
        int years;
        
        
        public StringTransformer(string teachername, int teacherYears) 
        {
            name = teachername;
            years = teacherYears;
         
        }

        public StringTransformer(string teacherNameOveConRever) 
        {
            name = teacherNameOveConRever;
        }


        /// Complete the solution so that it reverses all of the words within the string passed in. <summary>
        /// 
        /// Elbek Normurodov </summary>
        /// <returns>Normurodov Elbek</returns>
        public string ReverseWords()
        {
            string[] strArray = name.Split(' ');
            Array.Reverse(strArray);
            string resalt = string.Join(' ', strArray);

            return resalt;
        }

        ///Make a function that will return a greeting statement that uses an input; your program should return <summary>
        /// 
        /// name = Elbek Normurodov</summary>
        /// <returns>"Hello, <name> how are you doing today?".</returns>
        public string Greet()
        {
            return $"Hello, {name} how are you doing today?";
        }

        /// It's pretty straightforward. Your goal is to create a function that removes the first and 
        /// last characters of a string. You're given one parameter, the original string. 
        /// You don't have to worry with strings with 
        /// less than two characters.<summary>
        /// 
        /// name = Elbek Normurodov</summary>
        /// <returns>lbek Normurodo</returns>
        public string Remove_char()
        {
            return name.Substring(1, (name.Length - 2));
        }

    }
        
        
        
   
}







    
            
    
    

 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     
    
    
    
    
    
    



     






