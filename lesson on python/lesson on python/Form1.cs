using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_on_python
{
    public partial class menu : Form
    {
        private int currentLesson = 1;
        private int currentLesson2 = 0;
        private bool lssnr =  false;
        private bool lssnr2 = false;
        private bool lssnr3 = false;
        private bool lssnr4 = false;
        private bool lssnr5 = false;
        private bool lssnr6 = false;
        private bool lssnr7 = false;
        private bool lssnr8 = false;
        private bool lssnr9 = false;
        private bool lssnr10 = false;
        private bool lssnr11 = false;
        private bool lssnr12 = false;

        public menu()
        {
            InitializeComponent();

        }
        
        private void OnLesson1Completed()
        {
            lesson2.Enabled = true;
            lesson2.BackColor = Color.Gold;
        }

        private void lesson7_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson6Completed)
            {
                MessageBox.Show("Сначало завершите урок 6");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 7. Словари.\rСловарь — это как коробка с игрушками. У каждого значения есть своё имя (ключ),\rпо которому его можно найти.\rВот несколько примеров:\r\nmy_dict = {} //пустой словарь\r\nperson = {    \"имя\": \"Анна\",    \"возраст\": 15,   \"город\": \"Москва\"} //cловарь с данными (ключ : значение)\r\nprint(person[\"имя\"])      # Анна\r\nprint(person[\"возраст\"])  # 15 //как получить значение по ключу\r\r\nperson[\"class\"] = 8   // Добавление\r\nperson[\"age\"] = 16    // Изменение\r\ndel person[\"class\"] // Удаление \rЗадание: дан словарь products = {\"хлеб\": 30, \"молоко\": 60, \"яйца\": 80} (писать не надо). \rСделайте сами: 1) Выведите цену молока, 2)Добавить сыр за 150, 3) Увеличить цену хлеба на 10 ");
            form3.SetLessonNumber(7);
            form3.Show();

            if (!lssnr7)
            {
                lssnr7 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson1_Click(object sender, EventArgs e)
        {
            
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null )
            {
                form3 = new Form3();
            }
            currentLesson = 1;

     
            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 1. Зачем нам Python и что с ним делают?\r\nPython - это мультиинструмент для программиста.\r\nПредставьте, что вы получили швейцарский нож, который умеет многое:\r\n1) считать миллионы чисел за секунду.\r\n2) скачать все картинки с сайта\r\n3) сделать калькулятор, игр или сайт\r\nИ много чего еще!\r\n\r\nPython - это самый популярный язык в мире, зная его можно дальше изучать другие языки\r\n\r\nТеперь напишем код, вывода надписей\r\nчтобы вывести текст используется print(\" \") скобки и ковычки обязательно (в ковычках вы пишете то,\n что хотите вывести)\nНапишите программу, вывода текста Я умею программировать!");
            form3.SetLessonNumber(1);
            
            form3.Show();
            

            if (!lssnr)
            {
                lssnr = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
            lesson2.Enabled = true;
            lesson2.BackColor = Color.Gold;
        }

        private void lesson2_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson1Completed)
            {
                MessageBox.Show("Сначало завершите урок 1");
                return;
            }

            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }
            currentLesson = 2;

            


            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 2. Что такое переменные? \r\nПредставте, что переменная - это коробка\rв которую можно положить числа, слова и т.д.\r\n\rК примеру:\rage = 25 //числа можно писать без ковычек\rname = \"Коля\" //вот слова надо писатьв ковычках\r\n\rПеременные используются во всех программах, их лучше всего писать в начале программы,\rесли хотите вывести информацию с переменных, то можно писать само название переменных.\r\n\rНапишите программу, которая сохранит и выведет ваше имя, возраст и город и выведет в порядке \rимя, возраст, город");
            form3.SetLessonNumber(2);
            form3.Show();

            if (!lssnr2)
            {
                lssnr2 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
            }

        }

        private void lesson3_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson2Completed)
            {
                MessageBox.Show("Сначало завершите урок 2");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }
            currentLesson = 3;


            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 3. Ввод и вывод информации. \rС выводом информации мы познакомились на 1 уроке, \rно с вводом информации мы сейчас познакомимся. \rВвод информации - это то, что мы запрашиваем у пользователя. Мы это делаем с помощью imput.\r\n\r Пример: имя = imput(\"Как тебя зовут?\") //запрашиваем имя с подсказкой \r\n\rПреобразование разных типов данных:\r К примеру:\r возраст = int(input(\"Сколько лет?\")) //Преобразование из скроки в число\r print(возраст + 5) //так будет работать \r\n\rЗадание: Напишите программу Калькулятора сложения, запросите 2 числа и выведите их сумму.\r(Первое число -  a, Второе число - b");
            form3.SetLessonNumber(3);
            form3.Show();

            if (!lssnr3)
            {
                lssnr3 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson4_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson3Completed)
            {
                MessageBox.Show("Сначало завершите урок 3");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 4. Проверка информации (условный оператор). \rЧто такое условный оператор? Это функция позволяет программе принимать решения:\rвыполнить код или нет, в зависимости от условия.\rПростой пример: \rif условие:\r\n    # код, если условие ИСТИННО\r\nelse:\r\n    # код, если условие ЛОЖНО \r\n\rЭто если условие 1, если несколько, то между мини добавляется elif\r\n\rНапишите програму для проверки пароля.");
            form3.SetLessonNumber(4);
            form3.Show();

            if (!lssnr4)
            {
                lssnr4 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson5_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson4Completed)
            {
                MessageBox.Show("Сначало завершите урок 4");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 5. Циклы. \rциклы нужны для того, чтобы повторять одно и тоже действие несколько раз. Если известно\rсколько повторений будет используется for, если не известно while. Пример:(если известно)\r# Вывести числа от 1 до 10\r\nfor i in range(1, 11) //первое число - начало второе - последнее, третье - шаг:\r\n    print(i)\r(если неизвестно) \rcount = 0\rwhile count < 3:\r\n    print(f\"Счетчик: {count}\")\r\n    count = count + 1\r\n# Вывод: Счетчик: 0, 1, 2 \rНапишите программу, которая вывод все нечетные числа от 1 до 20.");
            form3.SetLessonNumber(5);
            form3.Show();

            if (!lssnr5)
            {
                lssnr5 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson6_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson5Completed)
            {
                MessageBox.Show("Сначало завершите урок 5");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 6. Списки. \rСписки - это коробка, в которую можно положить много разных предметов(слова, числа и даже\rдругие списки) К примеру: \rmy_list = []    //Пустой список\r\nnumbers = [1, 2, 3, 4, 5]    //с числами\r\nfruits = [\"яблоко\", \"банан\", \"апельсин\"]    //со словами\r\nmix = [10, \"привет\", True, 3.14]    //список с разным (можно) \r\n\rfruits = [\"яблоко\", \"банан\", \"апельсин\"]\r\nprint(fruits[0])  # яблоко //Получаем элемент по индексу (номеру начиная с 0)\r\n\r# Отрицательные индексы — с конца\r\nprint(fruits[-1])  # апельсин (последний начинается с -1 и идет с права на лево). \rЗадание: дан список n = [10, 20, 30, 40, 50] (писать не надо). Вывести первое и последнее число.0");
            form3.SetLessonNumber(6);
            form3.Show();

            if (!lssnr6)
            {
                lssnr6 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson8_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson7Completed)
            {
                MessageBox.Show("Сначало завершите урок 7");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 8. Функции. \rФункция — это маленькая программа внутри большой. Написал код один раз — используешь много раз.\rЧтобы создать функцию надо использовать -- def переменная(): передать данные -- def имя(параметр):\rВот небольшой пример: \r# Функция 1\r\ndef say_bye():\r\n    print(\"До свидания!\") //правило: когда создаете функцию само действие в нем писать после 4 пробелов\r\n# Функция 2\r\ndef multiply(a, b):\r\n    print(a * b)\r\n# Вызов\r\nsay_bye()           # До свидания!\r\nmultiply(4, 5)      # 20\r\nmultiply(7, 3)      # 21\r Задание: создайте функцию, которая проверяет, чётное ли число, в конце проверьте 4 и 7");
            form3.SetLessonNumber(8);
            form3.Show();

            if (!lssnr8)
            {
                lssnr8 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson9_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson8Completed)
            {
                MessageBox.Show("Сначало завершите урок 8");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 9. Строки.\rСтроки - это текст, последовательность символов в кавычкач \"привет\". \rПримеры взаимодействиея со  строками: \rs = \"Привет\"\rprint(len(s))  #длина строки = 6 \rprint(s[0]) #получаем символ по индексу(П)    print(s[-1]) #последний (т) \r# Срез (часть строки)\r\nprint(s[1:4])           # рив (с 1 по 3) счет начинается с 0\r\nprint(s[:3])            # При (первые 3) \ra = \"При\"\r\nb = \"вет\"\r\nprint(a + b)     #выведет: Привет \rprint(\"Ха\" * 3)         # выведет: ХаХаХа \rЗадание: f = \"apple\" выведите 1,  предпоследнюю букву и эту строку 5 раз. ");
            form3.SetLessonNumber(9);
            form3.Show();

            if (!lssnr9)
            {
                lssnr9 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson10_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson9Completed)
            {
                MessageBox.Show("Сначало завершите урок 9");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 10. Исправление ошибок и как их не допускать. \rЕсли вы делаете программы не забывайте о главных вещах, так можно будет не только избежать ошибок,\rно и если они всё таки появится, вам будет проще их найти и исправить: \r   1.Называйте переменные правильно (по назначению) пример city = \"Москва\"\r   2.Ставить коментарии (для действий чтоб не запутатся(помогает преимущественно тогда, когда\rвы не можете найти ошибки))\rСамый главный совет: никогда не бойтесь ошибок, ведь даже самые крутые кодеры, хоть иногда,\r но совершают ошибки. Надо уметь их выявлять и устранять. \r в python коментарии ставятся с помощью #, после этого символа можно писать всё что угодно \rи оно будет видно только в коде \rЗадание: напишите Понятно!");
            form3.SetLessonNumber(10);
            form3.Show();

            if (!lssnr10)
            {
                lssnr10 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson11_Click(object sender, EventArgs e)
        {
            if (!Form3.lesson10Completed)
            {
                MessageBox.Show("Сначало завершите урок 10");
                return;
            }
            // Проверяем, открыта ли уже вторая форма
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
            {
                form3 = new Form3();
            }

            // Передаём данные в label второй формы
            form3.SetLabelText("Урок 11. Модули. Готовые инструменты \rМодули в Python — файлы с кодом (.py), которые можно импортировать, чтобы повторно использовать\r\nфункции, классы и переменные. Модули помогают структурировать код и использовать его повторно.\r\nПолезные стандартные модули:\r\nmath — математика (sqrt, sin, pi и т. д.);\r\nrandom — случайные числа (randint, choice);\r\ndatetime — работа с датами и временем;\r\nos — взаимодействие с ОС;\r\nsys — параметры интерпретатора Python.\r\nПрименение\r\nimport mymath\r\nprint(mymath.add(5, 3))  # 8\r\nprint(mymath.PI)           # 3.14159 \r\nЗадание: Используя функцию из примера, Выведите сложение 3 и 5 (вместо +, add)");
            form3.SetLessonNumber(11);
            form3.Show();

            if (!lssnr11)
            {
                lssnr11 = true;
                currentLesson2++;
                label4.Text = $"Уроков пройдено: {currentLesson2}";
                return;
            }
        }

        private void lesson12_Click(object sender, EventArgs e)
        {
            if (currentLesson2 != 11)
            {
                MessageBox.Show("Сначало завершите предыдущие уроки");
            }
            else
            {
                Form2 form2 = Application.OpenForms["Form2"] as Form2;
                if (form2 == null)
                {
                    form2 = new Form2();
                }
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
