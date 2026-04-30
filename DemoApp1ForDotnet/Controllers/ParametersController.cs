using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace DemoApp1ForDotnet.Controllers
{
    public class ParametersController : Controller
    {
        //---default action method---
        public string Index()
        {
            return "This is the Index action method...";
        }
        //------Show action method without parameters----

        //----------------------------------------------------
        //this makes error or asp.net cannot recognise which one to implement
        // so use 1.Optional Params 2.Different Routes 3.Route Param
        //-------------------------------------------------------


        //public string Show()
        //{
        //    return "nothing!";
        //}
        //------Show action method with parameters------
        public string Show(string name, int age)
        {
            Console.WriteLine("Enterd Name: " + name + " Age: " + age);
            return $"From query String - Name: {name}, Age: {age}";
        }


        //---------Optional PArams
        public string OptionalShow(string? name , int? age)
        {
            if(string.IsNullOrEmpty(name) && age == null)
            {
                return "nothing";
            }

            return $"{name} - {age}";
        }
    }
}
