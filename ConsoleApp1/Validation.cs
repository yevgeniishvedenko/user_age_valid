using System;

namespace ConsoleApp1
{
  public class Validation : System.Attribute
        {
            public int Age { get; set; }
     
            public Validation()
            { }
     
            public Validation(int age)
            {
                Age = age;
            }
        }

}