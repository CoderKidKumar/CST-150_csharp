using System;
using System.IO;

namespace Activity12_FileEndWith
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           

            string filepath = @"textDocument.txt";

            Console.WriteLine("There are "+ findTE(textSplitter(readMyFile(filepath)))+" words that end with a 't' or an 'e' from the text above.");
        }

        private static String readMyFile(string filepath)
        {
            string filePlainText = File.ReadAllText(filepath);
            Console.WriteLine(filePlainText + "\n");
            return filePlainText;
        }

        //main method to find t and e
        private static int findTE(string[] wordArray)
        {
            int countTE = 0;
            for (int position = 0; position < wordArray.Length; position++)
            {
                string wordString = wordArray[position];
                if (wordString.EndsWith("t") || wordString.EndsWith("e") || wordString.EndsWith("T") || wordString.EndsWith("E"))
                    countTE++;
            }
            return countTE;
        }

        //method to split words in
        private static String[] textSplitter(string fileText)
        {
            //set the chars to split the text by
            char[] splittingChars = { ' ', ',', '.', ':', '\t' };

            //use the split method, put each word into array, and remove empty entries
            string[] words = fileText.Split(splittingChars, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }
    }
}
