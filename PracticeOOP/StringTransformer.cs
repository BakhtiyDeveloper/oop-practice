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
       


    }
        
        
        
   
}







    
            
    
    

 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     
    
    
    
    
    
    



     






