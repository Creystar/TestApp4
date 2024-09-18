using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class EnteringInteger
{
    static void Main()
    {
        //Текстовые переменные
        string res, txt;

        //Целочисленные переменные
        int year = 2024, age, born;

        //Отображение окна с полем ввода:
        res = Interaction.InputBox("В каком году вы родились?","Год рождения");

        //Преобразование текста в число:
        born=short.Parse(res);

        //Вычисление возраста:
        age=year-born;
        txt = "Тогда вам " + age + " лет";

        //Окно с сообщением
        MessageBox.Show(txt, "Возраст");
    }
}