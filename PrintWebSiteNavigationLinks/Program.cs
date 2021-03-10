using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWebSiteNavigationLinks
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();
            var data = SetupTestData();
            PrintNavigationItems(data.Children,output);
            File.WriteAllText("navigationsite.html", output.ToString());
            Console.ReadLine();
        }
        public static void PrintNavigationItems(List<NavigationItem> navigationItems,StringBuilder output)
        {
            if (navigationItems == null) return;
            Console.WriteLine($"<ul>");
            output.AppendLine($"<ul>");
            foreach (var item in navigationItems)
            {
                Console.WriteLine($"<li><a href='{item.Url}'>{item.Label}</a></li>");
                output.AppendLine($"<li><a href='{item.Url}'>{item.Label}</a></li>");
                PrintNavigationItems(item.Children,  output);
            }
            output.AppendLine($"</ul>");
            Console.WriteLine($"</ul>");
        }

        private static NavigationItem SetupTestData()
        {
            var nItem = new NavigationItem();
            nItem.Label = "Root";
            nItem.Url = "Root Url";
            nItem.Children = new List<NavigationItem>()
            {
                new NavigationItem()
                {
                    Label = "Level1",
                    Url = "Url1",
                    Children = new List<NavigationItem>()
                    {
                        new NavigationItem()
                        {
                            Label = "Level1-Sub1",
                            Url = "Url1-Sub1"
                        }
                    }
                },
                new NavigationItem()
                {
                    Label = "Level2",
                    Url = "Url2",
                    Children = new List<NavigationItem>()
                    {
                        new NavigationItem()
                        {
                            Label = "Level2-Sub1",
                            Url = "Url2-Sub1"
                        },
                        new NavigationItem()
                        {
                            Label = "Level2-Sub2",
                            Url = "Url2-Sub2"
                        }
                    }
                },
                new NavigationItem()
                {
                    Label = "Level3",
                    Url = "Url3",
                    Children = new List<NavigationItem>()
                    {
                        new NavigationItem()
                        {
                            Label = "Level3-Sub1",
                            Url = "Url3-Sub1"
                        }
                    }
                }

            };
            return nItem;
        }

        public class NavigationItem
        {
            public string Url;
            public string Label;
            public List<NavigationItem> Children;
        }

    }
}
