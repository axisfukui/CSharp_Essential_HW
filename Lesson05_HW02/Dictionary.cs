using System;

namespace Lesson05_HW02
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];

        public int Length { get { return key.Length; } }
        /// <summary>
        /// Индексатор Словаря
        /// </summary>
        /// <param name="index">Ключ слово, которое требуется перевести</param>
        /// <returns>Возвращает/Принимает перевод Ключ Слова</returns>
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return $"{key[i]} - {value[i]}";

                }
                return "Такого слова не найдено";
            }
            set
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == null)
                    {
                        this.key[i] = index;
                        this.value[i] = value;
                        return;
                    }
                }
                Console.WriteLine("Словарь заполнен. Свободных мест нет");


            }
        }

        /// <summary>
        /// Доступ к словарю по индексам
        /// </summary>
        /// <param name="index">Индекс списка слов</param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length) 
                    return $"{key[index]} - {value[index]} ";
                return "Выход за пределы Массива. Пара с заданым индексом отсутствует";
            }
        }
    }
}
