using System;
using System.IO;

namespace WordChallenge2
{
    // Cameron Nepe
    // ID: 1262199

    class Program
    {
        // declare variables
        // variable for reader object
        static string words = "";
        // array to store letter
        static char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P','Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        //static int total;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // variable to take calculation 
            int totalPrice = 0;
            // declare streamreader variable
            StreamReader reader;           
            // open the file and get a Streamreader object            
            reader = File.OpenText("sowpods.txt");
            while (!reader.EndOfStream)
            {
                try
                {
                    // read and display the first word
                    words = reader.ReadLine();
                    // convert to uppercase
                    words.ToUpper();
                    // Splitting the word in component characters or letters
                    char[] letters = words.ToCharArray(0,words.Length);
                    // check the reader variable
                    Console.WriteLine(words);
                    // iterate through the letters array
                    for(int i = 0; i < letters.Length; i++)
                    {
                        // iterate through the alphabet array
                        for (int j = 0; j < alphabet.Length; j++)
                        {
                            if (letters[i] == alphabet[j])
                            {
                                totalPrice += j + 1;
                            }
                        }
                    }
                    // check total is between $90 to $100
                    if (totalPrice > 89 && totalPrice < 111)
                    {
                        Console.WriteLine(words + " Has a value of $ " + totalPrice.ToString());
                    }                 
                    // reset to 0, the total price variable
                    totalPrice = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // Wait for user to have read the output
                Console.WriteLine();
                Console.Write("<Press enter to iterate to the next word>");
                Console.ReadLine();
            }
        }
    }
}
