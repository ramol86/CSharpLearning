using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using FamilyLibrary;
using FriendLibrary;

namespace AccessModifierExecutionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

             GrandfatherAssets oGrandpa = new GrandfatherAssets();
            PrintAll(oGrandpa);


            var objRelative =new Relatives();
            PrintAll(objRelative);

            var ObjDescendant = new Descendants();
            PrintAll(ObjDescendant);

             var Objfriends = new Friends();
            PrintAll(Objfriends);
            var ObjCloseFriends = new CloseFriend();

             PrintAll(ObjCloseFriends);

            Console.ReadLine();
        }

        static void PrintAll(object obj)
        {
            Console.WriteLine("------------------------------------------");

            foreach (var prop in obj.GetType().GetProperties(BindingFlags.Public| BindingFlags.Instance|BindingFlags.NonPublic).ToList().OrderByDescending(t=>t.Name))
            {


                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(obj, null));
            

            }
           
        
        }
    }
}
