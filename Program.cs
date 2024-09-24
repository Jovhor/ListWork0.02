using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWork0._02
{
    class Program
    {
        /// <summary>
        /// Заполнение телефонного справочника
        /// </summary>
        /// <param name="phoneBook"></param>
        static void FillDictionary(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Введите номера телефонов и ФИО владельцев. Для завершения введите пустую строку.");
            while (true)
            {
                Console.Write("Номер телефона: ");
                string phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    break; // Завершаем ввод, если введена пустая строка
                }

                Console.Write("ФИО владельца: ");
                string ownerName = Console.ReadLine();

                phoneBook[phoneNumber] = ownerName;
            }
        }

        /// <summary>
        /// Поиск пользователя по номеру телефона
        /// </summary>
        /// <param name="phoneBook"></param>
        static void SearchUser(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Введите номер телефона для поиска владельца:");

            string searchPhoneNumber = Console.ReadLine();
            if (phoneBook.TryGetValue(searchPhoneNumber, out string owner))
            {
                Console.WriteLine($"Владелец номера {searchPhoneNumber}: {owner}");
            }
            else
            {
                Console.WriteLine($"Владелец для номера {searchPhoneNumber} не найден.");
            }
        }
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Введите команду");
                Console.WriteLine("1 - Ввести номер телефона");
                Console.WriteLine("2 - Поиск по номеру телефона");
                Console.WriteLine("3 - Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": FillDictionary(phoneBook); break;
                    case "2": SearchUser(phoneBook); break;
                    case "3": Environment.Exit(0); break;
                    default: Console.WriteLine("Некорректный ввод. Попробуйте снова."); break;
                }
            }
        }
    }
}
