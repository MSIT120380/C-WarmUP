using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW2_TestStringArray_檢測字串內容含c或C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Gill", "Amber", "Roven", "Claire", "Erica", "Frederica", "Jo", "Lindsay", "Morris" };
            NameArray nameArray = new NameArray();
            nameArray.Name = name;

            Console.Write("\nName = ");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + "  ");
            }
            nameArray.LongestString();  //Print the longest name
            
            System.Collections.ArrayList nameWithC = nameArray.TestStringIncludeC();
            Console.Write("\nName(s) include c or C : ");
            foreach (string s in nameWithC)
            {
                Console.Write(s + "  ");
            }
            Console.WriteLine("\n\nThere are {0} names including c or C.", nameWithC.Count);
            Console.WriteLine("\n\n");
        }
        class NameArray
        {
            private string[] name;
          
            public string[] Name {
                get { return this.name; }
                set { this.name = value; }
            }
            public System.Collections.ArrayList TestStringIncludeC()
            {
                System.Collections.ArrayList nameWithCList = new System.Collections.ArrayList();
                for (int i = 0; i < name.Length; i++)       //Test if name[i] includes c or C. if true, turns nameIncludeC[i] to true
                {
                    for (int j = 0; j < name[i].Length; j++)
                    {
                        if (name[i][j] == 'c' || name[i][j] == 'C')
                        {
                            nameWithCList.Add(name[i]);
                        }
                    }
                }
                return nameWithCList;
            }
            public void LongestString()
            {
                for (int i = 0; i < name.Length - 1; i++)       //Sort the name array DESC with its Char Length (Bubble Sort)
                {
                    for (int j = i + 1; j < name.Length; j++)
                    {
                        string temp = "";
                        if (name[i].Length < name[j].Length)
                        {
                            temp = name[i];
                            name[i] = name[j];
                            name[j] = temp;
                        }
                    }
                }
                Console.WriteLine("\n\nThe longest name = " + name[0]);
            }

        }
  
        
    }
}
