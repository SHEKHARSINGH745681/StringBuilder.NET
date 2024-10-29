// See https://aka.ms/new-console-template for more information
using System.Text;

StringBuilder s = new StringBuilder("HELLOSHEKHAR", 20); //limit 20

//s.Append("Shekhar");

//s.AppendLine("\n");//NEXT LINE
//s.Append("HelloShekharSingh");

// "shekhar" insert after 6th index 
//s.Insert(6, "shekhar");


//index 5 se remove hoga then 3 char. remove hoge
//s.Remove(5, 3);

// REPLACE MAIN EXIT WORD AND WRITE NEW WORD
//s.Replace("SHEKHAR", "Geeks For");

s.reverse();
Console.WriteLine(s);

