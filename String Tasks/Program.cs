//using System.Text;

//namespace StringTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(CorrectString("        EverytHing  i neeD,    is a CuP   of       CoFFee    "));

//        }

//        static string CorrectString(string text)
//        {
//            text = text.Trim().ToLower();

//            StringBuilder sb = new StringBuilder();

//            sb.Append(char.ToUpper(text[0]));

//            for (int i = 1; i < text.Length; i++)
//            {
//                if (text[i] != ' ')
//                {
//                    if (text[i - 1] == ' ')
//                    {

//                        sb.Append(char.ToUpper(text[i]));
//                    }
//                    else sb.Append(text[i]);

//                }

//                if (text[i] == ' ')
//                {

//                    sb.Append(' ');

//                    while (text[i] == ' ')
//                    {
//                        i++;
//                    }
//                    i--;

//                }
//            }

//            return sb.ToString();


//        }
//    }


//}