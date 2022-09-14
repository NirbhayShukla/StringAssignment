using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("Character at index 12 is : " + s[12]);
            Console.WriteLine("Does string contains \"is\" : "+s.Contains("is"));
            s = s + " and killed it";
            Console.WriteLine(s);
            Console.WriteLine("Does string ends with \"dogs\" : " + s.EndsWith("dogs"));
            Console.WriteLine(s.Equals("The quick brown fox jumps over the lazy Dog"));
            Console.WriteLine("Length : " + s.Length);
            s = s.Replace("the", "a");
            Console.WriteLine(s);
            string[] arr= s.Split("over");
            Console.WriteLine(String.Join(",",arr));
            s = s.ToLower();
            Console.WriteLine(s);
            s = s.ToUpper();
            Console.WriteLine(s);
            Console.WriteLine("Position of \"a\" is : " + s.IndexOf('a'));
            Console.WriteLine("Position of \"e\" from last is : " + s.LastIndexOf('e'));
            Console.WriteLine("Enter the home directory of Tomcat Server");
            string path = Console.ReadLine();
            string newpath = @"Webapps/MyApp/Images/" + path;
            Console.WriteLine(newpath);
            const string poem = @"I wandered lonely as a cloud" + 
                @"That floats high over vales or hills" + 
                @"When all at once I saw a crowd" + 
                @"A host, a garden of daffodils; Besides the lake, beneath the trees" +
@"Fluttering and dancing in the breeze";
            Console.WriteLine(poem);

        }
    }
}
