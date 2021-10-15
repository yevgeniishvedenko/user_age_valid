using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
             
            Console.WriteLine("Введите возраст:");
            int age = Int32.Parse(Console.ReadLine());
 
            User user = new User { Name = name, Age = age };
             
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            Console.Read();
            Console.WriteLine($"{user.Name} {user.Age}");
            
            bool userIsValid = ValidateUser(user);
            Console.WriteLine($"Реультат валидации пользователя с именем: {user.Name} :: {userIsValid}");
            Console.ReadLine();
            
        }
        static bool ValidateUser(User user)
        {
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (Validation attr in attrs)
            {
                if (user.Age >= attr.Age) return true;
                else return false;
            }
            return true;
        }

    }
    
    
}