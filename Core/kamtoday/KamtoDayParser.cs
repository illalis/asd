using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html;
using AngleSharp.Html.Dom;

namespace Parser.Core.Habra
{
    class KamtoDayParser : IParser<string[]>
    {
        List<string> PermittedList = new List<string>() {
        "вулкан",


        };
        public static List<string> RemoveDuplicates(List<string> list1)
        {
          
            return list1.Distinct().ToList();
        }


        public string[] Parse(IHtmlDocument document)
        {

            

            var list  = new List<string>();
            var items = document.QuerySelectorAll("a, span").Where(item => item.ClassName != null && (item.ClassName.Contains("name") || item.ClassName.Contains("date darkgray")));
           // int i = 0;

            foreach(var item in items)
            {
               
                list.Add(item.TextContent);
                
                list.Remove("#Экология");

                
                }
            
            string filepath = "D:\\AllData.txt";
            StreamWriter f = new StreamWriter("D:\\AllData.txt", true);
            for (int i = 0; i < list.Count ; i++)
            {
                f.WriteLine(list[i]);

            }

            f.Close();
            //  List<string> list1 = list.Distinct().ToList();
           

       


            return list.ToArray();
        }
    }
}
