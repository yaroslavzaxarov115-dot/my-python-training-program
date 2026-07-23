using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_on_python
{
    public partial class Form3 : Form
    {
        private int currentLessonInForm3 = 1; //переменная для хранения урока
        public Form3()
        {
            InitializeComponent();
        }

        

        public static bool lesson1Completed { get; set; } = false;
        public static bool lesson2Completed { get; set; } = false;
        public static bool lesson3Completed { get; set; } = false;
        public static bool lesson4Completed { get; set; } = false;
        public static bool lesson5Completed { get; set; } = false;
        public static bool lesson6Completed { get; set; } = false;
        public static bool lesson7Completed { get; set; } = false;
        public static bool lesson8Completed { get; set; } = false;
        public static bool lesson9Completed { get; set; } = false;
        public static bool lesson10Completed { get; set; } = false;

        public static bool lesson11Completed { get; set; } = false;
        //статическое свойство передача между формами


        public void SetLabelText(string message)
        {
            label1.Text = message;
        }
        public void SetLessonNumber(int lesson)
        {
            currentLessonInForm3 = lesson;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //не нужно
        }

        private void bttnpr_Click(object sender, EventArgs e)
        {
            string userInput = rchTxtBx1.Text;
            string cleaned = userInput.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");

            // ========== УРОК 1 ==========
            if (currentLessonInForm3 == 1)
            {
                if (cleaned.Contains("print(\"Яумеюпрограммировать!\")") ||
                    userInput.Contains("print(\"Я умею программировать!\")"))
                {
                    rchTxtBx2.Text = " Правильно! Текст выведен.";
                    
                    lesson1Completed = true;

                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }

            }

            // ========== УРОК 2 ==========
            else if (currentLessonInForm3 == 2)
            {
                bool hasName = userInput.Contains("name") || userInput.Contains("имя");
                bool hasAge = userInput.Contains("age") || userInput.Contains("возраст");
                bool hasCity = userInput.Contains("city") || userInput.Contains("город");
                bool hasPrint = userInput.Contains("print");


                if (hasName && hasAge && hasCity && hasPrint)
                {
                    rchTxtBx2.Text = "Правильно! Переменные созданы и выведены.";

                    lesson2Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }

            // ========= УРОК 3 =========
            else if (currentLessonInForm3 == 3)
            {
                // Проверяем ТОЛЬКО ключевые элементы (не точное совпадение)
                bool hasPrintCalc = userInput.Contains("Калькулятор");
                bool hasInputA = userInput.Contains("Первое число") && (userInput.Contains("int(input") || userInput.Contains("a ="));
                bool hasInputB = userInput.Contains("Второе число") && (userInput.Contains("int(input") || userInput.Contains("b ="));
                bool hasSum = userInput.Contains("Сумма") && (userInput.Contains("a+b") || userInput.Contains("a + b"));

                if (hasPrintCalc && hasInputA && hasInputB && hasSum)
                {
                    rchTxtBx2.Text = "Правильно! Калькулятор работает.";

                    lesson3Completed = true;

                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                    
                }
            }



            // ========= УРОК 4 =========
            else if (currentLessonInForm3 == 4)
            {
                
                if (userInput.Contains("if") && userInput.Contains("else"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson4Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }


            // ========= УРОК 5 =========
            else if (currentLessonInForm3 == 5)
            {
                if (userInput.Contains("for") && userInput.Contains("range") && userInput.Contains("(1,21,2") && userInput.Contains("print"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson5Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }


            // ========= УРОК 6 =========
            else if (currentLessonInForm3 == 6)
            {
                if (userInput.Contains("print(n[0])") && userInput.Contains("print(n[-1])"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson6Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }

            }



            // ========= УРОК 7 =========
            else if (currentLessonInForm3 == 7)
            {
                if (userInput.Contains("print(products[\"молоко\"])") && userInput.Contains("products[\"сыр\"] = 150") && userInput.Contains("product[\"хлеб\"] = 40"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson7Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }


            // ========= УРОК 8 =========
            else if (currentLessonInForm3 == 8)
            {
                if (userInput.Contains("def") && userInput.Contains("if") && userInput.Contains("print") && userInput.Contains("else") && userInput.Contains("print"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson8Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }


            // ========= УРОК 9 =========
            else if (currentLessonInForm3 ==  9)
            {
                if (userInput.Contains("print(f[0])") && userInput.Contains("print(f[-2]") && userInput.Contains("print(f * 5)"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson9Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }

            // ========= УРОК 10 =========
            else if (currentLessonInForm3 == 10)
            {
                if (userInput.Contains("Понятно!"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson10Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }

            // ========= УРОК 11 =========
            else if (currentLessonInForm3 == 11)
            {
                if (userInput.Contains("import mymath") && userInput.Contains("print(mymath.add(5, 3))"))
                {
                    rchTxtBx2.Text = "Правильно!";

                    lesson10Completed = true;
                }
                else
                {
                    rchTxtBx2.Text = "Ошибка, нажмите сбросить и повторите попытку";
                }
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            rchTxtBx1.Text = " ";
            rchTxtBx2.Text = " ";
            rchTxtBx1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentLessonInForm3 == 1)
            {
                rchTxtBx1.Text = "print(\"Я умею программировать!\")";
            }
            else if (currentLessonInForm3 ==2)
            {
                rchTxtBx1.Text = "name = \"имя \"\rage = возраст\rcity = \"город\"\rprint(name, age, city)";
            }
            else if (currentLessonInForm3 ==3)
            {
                rchTxtBx1.Text = "print(\"Калькулятор сложения\") \ra = int(input(\"Первое число: \")) \rb = int(input(\"Второе число: \"))\rprint(\"Сумма\", a + b)";
            }
            else if (currentLessonInForm3 ==4)
            {
                rchTxtBx1.Text = "password = 12345 \rif password == 12345 \r     print(\"Доступ разрешён\")\relse\r     print(\"Доступ запрещён\")";
            }
            else if (currentLessonInForm3 ==5)
            {
                rchTxtBx1.Text = "for i in range(1,21,2)\r     print(i)";
            }
            else if (currentLessonInForm3 ==6)
            {
                rchTxtBx1.Text = "print(n[0])\rprint(n[-1])";
            }
            else if (currentLessonInForm3 ==7)
            {
                rchTxtBx1.Text = "print(products[\"молоко\"])\r\nproducts[\"сыр\"] = 150\r\nproduct[\"хлеб\"] = 40";
            }
            else if (currentLessonInForm3 ==8)
            {
                rchTxtBx1.Text = "def check_even(num):\r\n    if num % 2 == 0:\r\n        print(\"Чётное\")\r\n    else:\r\n        print(\"Нечётное\")\r\n\r\ncheck_even(4)  # Чётное\r\ncheck_even(7)  # Нечётное";
            }
            else if (currentLessonInForm3 ==9)
            {
                rchTxtBx1.Text = "print(f[0])\r\nprint(f[-2])\r\nprint(f * 5)";
            }
            else if (currentLessonInForm3 ==10)
            {
                rchTxtBx1.Text = "Понятно!";
            }
            else if (currentLessonInForm3 ==11)
            {
                rchTxtBx1.Text = "import mymath\r\nprint(mymath.add(5, 3))";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
