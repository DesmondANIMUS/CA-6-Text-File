using System;
using System.IO;
namespace CA_6_Text_File
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("C:\\Users\\Desmond\\Documents\\Visual Studio 2015\\Projects\\Personal\\C#\\Console\\CA-6 Text File\\CA-6 Text File\\Data.txt");


            /*
            
                    In order to use StreamReader class to make the object, 
                    you will have to use (or shall I say include) the namespace called 
                    Syatem.IO. So, unless you have ReSharper, you will have to 
                    "include" that Namespace yourself. 
                    
                    Notice that these NameSpaces are equivalent to what you have header files 
                    in C / C++ and Packages in Java                                        
            
            */
        
            string line = "";
            while (line != null)
            {
                line = streamReader.ReadLine();
                if(line != null)
                    Console.WriteLine(line);
            }

            /* 
                  
                  Make sure you close your file everytime because if 
                  you do not do so then anyone with a half good file / application
                  processor could easily gain access to the file unless of course you
                  reboot your entire system or do something drastic such as that.                                      
             
            */

            streamReader.Close();
            Console.ReadLine();
        }
    }
}
