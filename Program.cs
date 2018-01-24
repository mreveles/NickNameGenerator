using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nicknames = new string [5];
            //row 1
            nicknames[0] = "Dude";
            //row2
            nicknames[1] = "Jones";
            //row3
            nicknames[2] = "Snappy";
            //row4
            nicknames[3] = "FireCracker";
            //row5
            nicknames[4] = "Bootstrap";

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            int j=0;

            foreach (var item in nicknames){
                Console.WriteLine(nicknames[j]);
                j+=1 ;
            }

            //string[] nameparts = name.Split(new char [' ']);

            /*for(int i = 0; i >nameparts.Length; i++){
                Console.WriteLine(nameparts[i]);
                Console.WriteLine();
            }
            for(int i= 0; i< nameparts.Length; i++ ){
            
             */
            }
        }
    }

