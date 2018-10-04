using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {

            //Function 1 works: y
            string[] userInput = new string[3];
            for (int a=0; a < 3; a++)
            {
                Console.WriteLine("Enter string!");
                userInput[a] = Console.ReadLine();
            }
            for(int j = 0; j <= 2; j++)
            {
                Console.WriteLine(userInput[j]);
            }
            //Function 1 end


            //Function 2 works: y
            List<string> list1 = new List<string>();
            list1.Add("Oh hi Mark");
            list1.Add("A real human bean");
            list1.Add("oof ouch owie my bones");

            string holder;

            holder = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (holder == list1[i])
                {
                    Console.WriteLine("Match at index: " + i);
                    found = true;
                    break;
                }
                if((i + 1) == list1.Count)
                {
                    if (found == false)
                    {
                        Console.WriteLine("I'm sorry, but the string you entered doesn't exist.");
                    }
                }

            }
            


            //Function 2 end


            //Function 3 works: y

            List<string> list2 = new List<string>();
            list2.Add("This is the same");
            list2.Add("This is not the same");
            list2.Add("This is the same");

            Console.WriteLine("Enter a string: ");
            holder = Console.ReadLine();
            bool match = false;

            for (int i = 0; i < list2.Count; i++)
            {
                if (holder == list2[i])
                {
                    Console.WriteLine("Match found in the " + i + " index.");
                    match = true;
                }
                if ((i + 1) == list2.Count)
                {
                    if (match == false)
                    {
                        Console.WriteLine("I'm sorry, but the string you entered doesn't exist.");
                    }
                }
            }

            //Function end

            //Function 4 works: bug

            List<string> list3 = new List<string>();
            list3.Add("111");
            list3.Add("121");
            list3.Add("111");

            List<string> listHold = new List<string>();


            foreach(string str in list3)
            {
                    if (!listHold.Contains(str))
                    {
                        listHold.Add(str);
                        Console.WriteLine(str);

                    }
                    else
                    {
                        Console.WriteLine(str + " is already here");
                    }
            }


            Console.ReadLine();
        }
    }
}
