using Practice5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HashPassword.Hash;

namespace Practice5
{
    internal class Helper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите отчество если есть:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            string hashedPassword = HashHelper.HashPassword(password);
            Console.WriteLine("Хешированный пароль: " + hashedPassword);

            Console.WriteLine("Введите роль, где 1 - Работник, 2 - Бухгалтер:");
            string roleCode = Console.ReadLine();

            Console.WriteLine("Введите номер телефона (11 цифр):");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Введите ID регистрации:");
            string UserCode = Console.ReadLine();

            RegisterUser(name, surname, patronymic, login, password, roleCode, phoneNumber, UserCode);
            Console.WriteLine("Пользователь успешно добавлен.");
            Console.ReadKey();
        }

        public static void RegisterUser(string name, string surname, string patronymic, string login, string password, string roleCode, string phoneNumber, string UserCode)
        {
            {
                using (var context = new prog_comEntities())
                {
                    try
                    {
                        string hashedPassword = HashHelper.HashPassword(password);

                        Employee_registration newEmployeeReg = new Employee_registration
                        {
                            Login = login,
                            Password = hashedPassword,

                        };
                        context.Employee_registration.Add(newEmployeeReg);
                        context.SaveChanges();
                        int parsedRoleCode = int.Parse(roleCode);
                        decimal parsedPhoneNumber = decimal.Parse(phoneNumber);

                        Employee newEmployee = new Employee
                        {
                            First_name = name,
                            Second_name = surname,
                            Patronymic = patronymic,
                            Employee_type_code = parsedRoleCode,
                            Mobile_number = parsedPhoneNumber,
                            Employee_registration_code = newEmployeeReg.Employee_registration_code
                        };
                        context.Employee.Add(newEmployee);
                        context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {
                        foreach (var validationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка формата: проверьте что значения Employee_type_code и Employee_registration_code являются числами");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: значения Employee_type_code или Employee_registration_code слишком велики или малы для типа Int32.");
                    }
                }
            }

        }
    }
}
