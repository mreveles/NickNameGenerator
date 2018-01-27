using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NickNameGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean onlyLetters = false;
            string name;
            int error = 0;
            int first=0;
            int last=0;

            string[,] nicknames = new string [5,2];
            //row 1
            nicknames[0,0] = "Roudy Recon";
            nicknames[0,1] = "JarHead";
            //row2
            nicknames[1,0] = "Jodie";
            nicknames[1,1] = "Boot";
            //row3
            nicknames[2,0] = "Yellow Birdy";
            nicknames[2,1] = "Raider";
            //row4
            nicknames[3,0] = "Mad Dog";
             nicknames[3,1] = "Devil Dog";
            //row5
            nicknames[4,0] = "LeatherNeck";
            nicknames[4,1] = "Rolling Thunder";

            do
            {
                //if second time over ask gives user more precise intructions
                if(error>0)
                {
                    if(error>100)
                    {
                        Console.WriteLine("How hard is it to fallow intructions? Letters are: ");
                        Console.WriteLine("a b c d e f g h i j k l m n o p q r s t u v w x y z");
                    }
                    Console.WriteLine("Something went wrong. Enter your name using only letters.");
                }
                //prompts user for name
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
                //checks to see user only entered characters and spaces
                if(Regex.IsMatch(name,@"^[a-zA-Z ]+$")){
                    onlyLetters = true;
                }
                //converts string to all caps
                name = name.ToUpper();
                //adds to error so if user has to repeat additional instructions are given
                error += 1;
                Console.WriteLine("Error = {0}", error);
            } while (onlyLetters == false);

            Console.WriteLine($"Hello {name}");
            //sends to refernce to convert name 
            double totalValue = getASCII(name);

            Console.WriteLine("Did you know the ASCII value of {0} is {1}", name, totalValue);

            
            if(totalValue <= 400)
            {
                first = 0;
            }
            if(totalValue >400 && totalValue<= 700){
                first = 1;
            }
            if(totalValue >700 && totalValue <=1000){
                first = 2;
            }
            if(totalValue >1000 && totalValue <=1300){
                first = 3;
            }
            if(totalValue >1300)
            {
                first = 4;
            }
            if((totalValue %2) != 0){
                last = 1;
            }
            Console.WriteLine("Your nickname is {0}", nicknames[first,last]);
            
        }
            /*
            public static string reverser(string original){

                char[] temp = original.ToCharArray();

                for(int i = 0; i < temp.Length; i++){
                    Console.WriteLine("{0}",temp[i]);
                }

                Array.Reverse(temp);
                Console.WriteLine(temp);

                string output = new string(temp);

                Console.WriteLine(output);
                //output += temp;

                return output;
            }
            */
            static double getASCII(string original)
            {
                
                double ASCIIvalue = 0;
                //converts string to bytes according to character value on ASCII
                byte[] ASCIIValues = Encoding.ASCII.GetBytes(original);
                //adds up the bytes and returns it to main void
                foreach(byte b in ASCIIValues) 
                {
                ASCIIvalue += b;
                }
                return ASCIIvalue;
            }
        }
    }