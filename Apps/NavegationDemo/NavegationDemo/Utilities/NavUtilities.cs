using NavegationDemo.MVVM.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegationDemo.Utilities
{
     public static class NavUtilities
     {
          public static void Examine(INavigation navigation)
          {
               StringBuilder builder = new StringBuilder();
               foreach(var page in navigation.NavigationStack)
               {
                    builder.AppendLine(page.GetType().Name);
               }
               builder.AppendLine("-----------");
               Debug.WriteLine(builder.ToString());
          }

          public static void InsertPage(INavigation navigation)
          {
               var secondPage =
                    navigation.NavigationStack
                    .ElementAtOrDefault(1);
               if(secondPage!=null)
               {
                    navigation.InsertPageBefore(new CoolPage(),
                         secondPage);
               }
          }

          public static void DeletePage(INavigation navigation, string pageName)
          {
               var pageToDelete =
                    navigation.NavigationStack
                    .FirstOrDefault(x => x.GetType().Name == pageName);
               if(pageToDelete !=null)
               {
                    navigation.RemovePage(pageToDelete);
               }
          }
     }
}
