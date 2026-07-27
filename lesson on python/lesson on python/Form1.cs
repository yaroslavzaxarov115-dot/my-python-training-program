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
        private bool[] lessonsCompleted = new bool[12]; //0 не используется, 1-11 уроки
        public menu()
        {
            InitializeComponent();

            // ===== ТЁМНАЯ ТЕМА =====
            this.BackColor = Color.FromArgb(30, 30, 30); // Тёмный фон
            this.ForeColor = Color.White;

            // ===== ЗАГОЛОВОК =====
            System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label();
            titleLabel.Text = "🐍 Обучение Python";
            titleLabel.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 150, 255); // Голубой
            titleLabel.Location = new Point(30, 20);
            titleLabel.AutoSize = true;
            this.Controls.Add(titleLabel);

            // ===== КНОПКИ УРОКОВ =====
            int x = 30, y = 80;
            int btnWidth = 130, btnHeight = 50;
            int spacing = 15;

            // Цвета для 11 уроков
            Color[] colors = {
        Color.FromArgb(231, 76, 60),  // Урок 1 - Красный
        Color.FromArgb(230, 126, 34), // Урок 2 - Оранжевый
        Color.FromArgb(241, 196, 15), // Урок 3 - Жёлтый
        Color.FromArgb(46, 204, 113), // Урок 4 - Зелёный
        Color.FromArgb(26, 188, 156), // Урок 5 - Бирюзовый
        Color.FromArgb(52, 152, 219), // Урок 6 - Синий
        Color.FromArgb(155, 89, 182), // Урок 7 - Фиолетовый
        Color.FromArgb(52, 73, 94),   // Урок 8 - Тёмно-синий
        Color.FromArgb(192, 57, 43),  // Урок 9 - Тёмно-красный
        Color.FromArgb(39, 174, 96),  // Урок 10 - Тёмно-зелёный
        Color.FromArgb(142, 68, 173)  // Урок 11 - Тёмно-фиолетовый
    };

            for (int i = 1; i <= 11; i++)
            {
                // Находим кнопку
                Button btn = this.Controls.Find($"lesson{i}", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Text = $"Урок {i}";
                    btn.BackColor = colors[i - 1];
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Size = new Size(btnWidth, btnHeight);

                    // Располагаем в 3 ряда
                    int row = (i - 1) / 4;
                    int col = (i - 1) % 4;
                    btn.Location = new Point(x + col * (btnWidth + spacing), y + row * (btnHeight + spacing));
                }
            }

            // ===== КНОПКА "ТЕСТ 1" =====
            Button testBtn = new Button();
            testBtn.Text = "📝 Тест 1";  // ← Здесь НЕ "Тест 2"!
            testBtn.BackColor = Color.FromArgb(231, 76, 60);
            testBtn.ForeColor = Color.White;
            testBtn.FlatStyle = FlatStyle.Flat;
            testBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            testBtn.Size = new Size(130, 50);
            testBtn.Location = new Point(30, y + 3 * (btnHeight + spacing) + 20);
            testBtn.Click += lesson12_Click;
            this.Controls.Add(testBtn);

            // ===== ПРОГРЕСС-БАР =====
            progressBar1.Location = new Point(30, y + 3 * (btnHeight + spacing) + 80);
            progressBar1.Size = new Size(400, 25);
            progressBar1.BackColor = Color.FromArgb(45, 45, 45);
            progressBar1.ForeColor = Color.FromArgb(0, 150, 255);

            // ===== КНОПКА "ЗАКРЫТЬ" =====
            button1.Text = "✕ Закрыть";
            button1.BackColor = Color.FromArgb(180, 40, 40);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button1.Size = new Size(100, 40);
            button1.Location = new Point(30, y + 3 * (btnHeight + spacing) + 120);

            // === КРАСИВЫЙ СЧЁТЧИК ПРОГРЕССА ===
            label4.Text = $"Уроков пройдено: {currentLesson2} из 11";
            label4.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Крупный шрифт
            label4.ForeColor = Color.FromArgb(0, 200, 255); // Ярко-голубой
            
            label4.AutoSize = true;
            label4.Padding = new Padding(10, 5, 10, 5); // Отступы внутри
            
        }

        private void UpdateProgress()
        {
            progressBar1.Maximum = 11;
            progressBar1.Value = currentLesson2;
            label4.Text = $"Уроков пройдено: {currentLesson2} из 11";
        }

        private void OpenLesson(int lessonNumber, string lessonText)
        {
            // Проверяем, завершён ли предыдущий урок
            if (lessonNumber > 1 && !lessonsCompleted[lessonNumber - 1])
            {
                MessageBox.Show($"Сначала завершите урок {lessonNumber - 1}");
                return;
            }

            // Открываем форму с уроком
            Form3 form3 = Application.OpenForms["Form3"] as Form3;
            if (form3 == null)
                form3 = new Form3();

            form3.SetLabelText(lessonText);
            form3.SetLessonNumber(lessonNumber);
            form3.Show();

            // Отмечаем урок как пройденный
            if (!lessonsCompleted[lessonNumber])
            {
                lessonsCompleted[lessonNumber] = true;
                currentLesson2++;
                UpdateProgress();

                // Разблокируем следующий урок
                if (lessonNumber < 11)
                {
                    Control nextButton = Controls.Find($"lesson{lessonNumber + 1}", true).FirstOrDefault();

                }
            }
        }

        private string[] lessonTexts = new string[] //тексты для уроков
        {
            "", //0 не используем
            "Урок 1. Зачем нам Python и что с ним делают?\r\nPython - это мультиинструмент для программиста.\r\nПредставьте, что вы получили швейцарский нож, который умеет многое:\r\n1) считать миллионы чисел за секунду.\r\n2) скачать все картинки с сайта\r\n3) сделать калькулятор, игр или сайт\r\nИ много чего еще!\r\n\r\nPython - это самый популярный язык в мире, зная его можно дальше изучать другие языки\r\n\r\nТеперь напишем код, вывода надписей\r\nчтобы вывести текст используется print(\" \") скобки и ковычки обязательно (в ковычках вы пишете то,\n что хотите вывести)\nНапишите программу, вывода текста Я умею программировать!",
            "Урок 2. Что такое переменные? \r\nПредставте, что переменная - это коробка\rв которую можно положить числа, слова и т.д.\r\n\rК примеру:\rage = 25 //числа можно писать без ковычек\rname = \"Коля\" //вот слова надо писатьв ковычках\r\n\rПеременные используются во всех программах, их лучше всего писать в начале программы,\rесли хотите вывести информацию с переменных, то можно писать само название переменных.\r\n\rНапишите программу, которая сохранит и выведет ваше имя, возраст и город и выведет в порядке \rимя, возраст, город",
            "Урок 3. Ввод и вывод информации. \rС выводом информации мы познакомились на 1 уроке, \rно с вводом информации мы сейчас познакомимся. \rВвод информации - это то, что мы запрашиваем у пользователя. Мы это делаем с помощью imput.\r\n\r Пример: имя = imput(\"Как тебя зовут?\") //запрашиваем имя с подсказкой \r\n\rПреобразование разных типов данных:\r К примеру:\r возраст = int(input(\"Сколько лет?\")) //Преобразование из скроки в число\r print(возраст + 5) //так будет работать \r\n\rЗадание: Напишите программу Калькулятора сложения, запросите 2 числа и выведите их сумму.\r(Первое число -  a, Второе число - b",
            "Урок 4. Проверка информации (условный оператор). \rЧто такое условный оператор? Это функция позволяет программе принимать решения:\rвыполнить код или нет, в зависимости от условия.\rПростой пример: \rif условие:\r\n    # код, если условие ИСТИННО\r\nelse:\r\n    # код, если условие ЛОЖНО \r\n\rЭто если условие 1, если несколько, то между мини добавляется elif\r\n\rНапишите програму для проверки пароля.",
            "Урок 5. Циклы. \rциклы нужны для того, чтобы повторять одно и тоже действие несколько раз. Если известно\rсколько повторений будет используется for, если не известно while. Пример:(если известно)\r# Вывести числа от 1 до 10\r\nfor i in range(1, 11) //первое число - начало второе - последнее, третье - шаг:\r\n    print(i)\r(если неизвестно) \rcount = 0\rwhile count < 3:\r\n    print(f\"Счетчик: {count}\")\r\n    count = count + 1\r\n# Вывод: Счетчик: 0, 1, 2 \rНапишите программу, которая вывод все нечетные числа от 1 до 20.",
            "Урок 6. Списки. \rСписки - это коробка, в которую можно положить много разных предметов(слова, числа и даже\rдругие списки) К примеру: \rmy_list = []    //Пустой список\r\nnumbers = [1, 2, 3, 4, 5]    //с числами\r\nfruits = [\"яблоко\", \"банан\", \"апельсин\"]    //со словами\r\nmix = [10, \"привет\", True, 3.14]    //список с разным (можно) \r\n\rfruits = [\"яблоко\", \"банан\", \"апельсин\"]\r\nprint(fruits[0])  # яблоко //Получаем элемент по индексу (номеру начиная с 0)\r\n\r# Отрицательные индексы — с конца\r\nprint(fruits[-1])  # апельсин (последний начинается с -1 и идет с права на лево). \rЗадание: дан список n = [10, 20, 30, 40, 50] (писать не надо). Вывести первое и последнее число.0",
            "Урок 7. Словари.\rСловарь — это как коробка с игрушками. У каждого значения есть своё имя (ключ),\rпо которому его можно найти.\rВот несколько примеров:\r\nmy_dict = {} //пустой словарь\r\nperson = {    \"имя\": \"Анна\",    \"возраст\": 15,   \"город\": \"Москва\"} //cловарь с данными (ключ : значение)\r\nprint(person[\"имя\"])      # Анна\r\nprint(person[\"возраст\"])  # 15 //как получить значение по ключу\r\r\nperson[\"class\"] = 8   // Добавление\r\nperson[\"age\"] = 16    // Изменение\r\ndel person[\"class\"] // Удаление \rЗадание: дан словарь products = {\"хлеб\": 30, \"молоко\": 60, \"яйца\": 80} (писать не надо). \rСделайте сами: 1) Выведите цену молока, 2)Добавить сыр за 150, 3) Увеличить цену хлеба на 10 ",
            "Урок 8. Функции. \rФункция — это маленькая программа внутри большой. Написал код один раз — используешь много раз.\rЧтобы создать функцию надо использовать -- def переменная(): передать данные -- def имя(параметр):\rВот небольшой пример: \r# Функция 1\r\ndef say_bye():\r\n    print(\"До свидания!\") //правило: когда создаете функцию само действие в нем писать после 4 пробелов\r\n# Функция 2\r\ndef multiply(a, b):\r\n    print(a * b)\r\n# Вызов\r\nsay_bye()           # До свидания!\r\nmultiply(4, 5)      # 20\r\nmultiply(7, 3)      # 21\r Задание: создайте функцию, которая проверяет, чётное ли число, в конце проверьте 4 и 7",
            "Урок 9. Строки.\rСтроки - это текст, последовательность символов в кавычкач \"привет\". \rПримеры взаимодействиея со  строками: \rs = \"Привет\"\rprint(len(s))  #длина строки = 6 \rprint(s[0]) #получаем символ по индексу(П)    print(s[-1]) #последний (т) \r# Срез (часть строки)\r\nprint(s[1:4])           # рив (с 1 по 3) счет начинается с 0\r\nprint(s[:3])            # При (первые 3) \ra = \"При\"\r\nb = \"вет\"\r\nprint(a + b)     #выведет: Привет \rprint(\"Ха\" * 3)         # выведет: ХаХаХа \rЗадание: f = \"apple\" выведите 1,  предпоследнюю букву и эту строку 5 раз. ",
            "Урок 10. Исправление ошибок и как их не допускать. \rЕсли вы делаете программы не забывайте о главных вещах, так можно будет не только избежать ошибок,\rно и если они всё таки появится, вам будет проще их найти и исправить: \r   1.Называйте переменные правильно (по назначению) пример city = \"Москва\"\r   2.Ставить коментарии (для действий чтоб не запутатся(помогает преимущественно тогда, когда\rвы не можете найти ошибки))\rСамый главный совет: никогда не бойтесь ошибок, ведь даже самые крутые кодеры, хоть иногда,\r но совершают ошибки. Надо уметь их выявлять и устранять. \r в python коментарии ставятся с помощью #, после этого символа можно писать всё что угодно \rи оно будет видно только в коде \rЗадание: напишите Понятно!",
            "Урок 11. Модули. Готовые инструменты \rМодули в Python — файлы с кодом (.py), которые можно импортировать, чтобы повторно использовать\r\nфункции, классы и переменные. Модули помогают структурировать код и использовать его повторно.\r\nПолезные стандартные модули:\r\nmath — математика (sqrt, sin, pi и т. д.);\r\nrandom — случайные числа (randint, choice);\r\ndatetime — работа с датами и временем;\r\nos — взаимодействие с ОС;\r\nsys — параметры интерпретатора Python.\r\nПрименение\r\nimport mymath\r\nprint(mymath.add(5, 3))  # 8\r\nprint(mymath.PI)           # 3.14159 \r\nЗадание: Используя функцию из примера, Выведите сложение 3 и 5 (вместо +, add)",
        };


        private void OnLesson1Completed()
        {
            lesson2.Enabled = true;
            lesson2.BackColor = Color.Gold;
        }

        private void lesson7_Click(object sender, EventArgs e)
        {
            OpenLesson(7, lessonTexts[7]);
        }

        private void lesson1_Click(object sender, EventArgs e)
        {
            OpenLesson(1, lessonTexts[1]);
        }

        private void lesson2_Click(object sender, EventArgs e)
        {
            OpenLesson(2, lessonTexts[2]);
        }

        private void lesson3_Click(object sender, EventArgs e)
        {
            OpenLesson(3, lessonTexts[3]);
        }

        private void lesson4_Click(object sender, EventArgs e)
        {
            OpenLesson(4, lessonTexts[4]);
        }

        private void lesson5_Click(object sender, EventArgs e)
        {
            OpenLesson(5, lessonTexts[5]);
        }

        private void lesson6_Click(object sender, EventArgs e)
        {
            OpenLesson(6, lessonTexts[6]);
        }

        private void lesson8_Click(object sender, EventArgs e)
        {
            OpenLesson(8, lessonTexts[8]);
        }

        private void lesson9_Click(object sender, EventArgs e)
        {
            OpenLesson(9, lessonTexts[9]);
        }

        private void lesson10_Click(object sender, EventArgs e)
        {
            OpenLesson(10, lessonTexts[10]);
        }

        private void lesson11_Click(object sender, EventArgs e)
        {
            OpenLesson(11, lessonTexts[11]);
        }

        private void lesson12_Click(object sender, EventArgs e)
        {
            if (currentLesson2 != 0)
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
