using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_pdfHW_extra
{
    //Расширьте пример 5 (русско-английский словарь) еще и украинским словарем.
    //Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryUA dictionaryUA = new DictionaryUA();
            Dictionary dictionary = new Dictionary();
            Console.WriteLine("Украино-Английский");
            Console.WriteLine(dictionaryUA["pen"]);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine( dictionaryUA[i] );
            }
            Console.WriteLine("Русско-Английский");
            Console.WriteLine(dictionary["table"]);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dictionary[i]);
            }


            Console.ReadLine();
        }
    }
    class Dictionary
    {
        protected string[] key = new string[5];
        protected string[] value = new string[5];

        public Dictionary()
        {
            key[0] = "книга";   value[0] = "book";
            key[1] = "ручка";   value[1] = "pen";
            key[2] = "солнце";  value[2] = "sun";
            key[3] = "яблоко";  value[3] = "apple";
            key[4] = "стол";    value[4] = "table";
        }

        public virtual string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index || value[i] == index)
                        return key[i] + " - " + value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public virtual string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
    class DictionaryUA : Dictionary
    {
        public DictionaryUA()
        {
            key[0] = "книга";
            key[1] = "ручка";
            key[2] = "солнце";
            key[3] = "яблуко";
            key[4] = "стіл";
        }
         public override string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (this.key[i] == index || base.value[i] == index)
                        return key[i] + " - " + base.value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
        public override string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return this.key[index] + " - " + base.value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
