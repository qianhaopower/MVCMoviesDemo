//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FetchFile
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //string text = System.IO.File.ReadAllText(@"C:\Users\hao.qian.COMOPS\Desktop\DeleteOrgPosCC.txt");

//            //// Display the file contents to the console. Variable text is a string.
//            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

//            //// Example #2 
//            //// Read each line of the file into a string array. Each element 
//            //// of the array is one line of the file. 
//            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\hao.qian.COMOPS\Desktop\DeleteOrgPosCC.txt");

//            //// Display the file contents by using a foreach loop.
//            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
//            //foreach (string line in lines)
//            //{
//            //    // Use a tab to indent each line of the file.
//            //    Console.WriteLine("\t" + line);
//            //}

//            //// Keep the console window open in debug mode.
//            //Console.WriteLine("Press any key to exit.");
//            //System.Console.ReadKey();



//            FileStream fileStream = new FileStream(@"C:\Users\hao.qian.COMOPS\Desktop\DeleteOrgPosCC.txt", FileMode.Open);
//            try
//            {
//                // read from file or write to file
//                string fileContents;
//                using (StreamReader reader = new StreamReader(fileStream))
//                {
//                    fileContents = reader.ReadToEnd();
//                    System.Console.WriteLine("Contents of WriteText.txt = {0}", fileContents);
//                    // Keep the console window open in debug mode.
//                    Console.WriteLine("Press any key to exit.");
//                    System.Console.ReadKey();


//                }
//            }
//            finally
//            {
//                fileStream.Close();
//            }

//        }
//    }
//}
