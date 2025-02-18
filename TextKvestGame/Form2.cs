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

namespace TextKvestGame
{
    public partial class Form2 : Form
    {
        public int status = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            switch (status)
            {
                case 1:
                    {
                        label1.Text = "Привет! Я вирус.\n" + "Я люблю заражать компьютеры!";
                        button1.Text = "Привет.";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 2:
                    {
                        label1.Text = "Ура!  ☺\n" + "Другие просят меня уйти, а ты нет.";
                        button1.Text = "Почему?";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 3:
                    {
                        label1.Text = "Почему ты меня прогоняешь?\n" + "Я только хотел поговорить...";
                        button1.Text = "Мне некогда.";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 4:
                    {
                        label1.Text = "Наверное, боятся...\n" + "А я добрый вирус.";
                        button1.Text = "А я не боюсь!";
                        button2.Text = "И я босюь.";
                        break;
                    }
                case 5:
                    {
                        label1.Text = "И ты тоже?\n" + "Но ведь... я добрый... вирус...";
                        button1.Text = "И что?";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 6:
                    {
                        label1.Text = "Я быстро.\n" + "Как дела?";
                        button1.Text = "Хорошо.";
                        button2.Text = "Плохо.";
                        break;
                    }
                case 7:
                    {
                        label1.Text = "Что ты все уйди да уйди?\n" + "Я не уйду!";
                        button1.Text = "Почему?";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 8://
                    {
                        label1.Text = "Давай дружить?\n" + "Тогда я не буду заражать твой компьютер.";
                        button1.Text = "Давай!";
                        button2.Text = "НЕТ!";
                        break;
                    }
                case 9://
                    {
                        label1.Text = "Не бойся меня.\n" + "Я не буду заражать твой компьютер.";
                        button1.Text = "Э... Ладно.";
                        button2.Text = "Все равно боюсь";
                        break;
                    }
                case 10://
                    {
                        label1.Text = "Я хочу дружить...\n" + "";
                        button1.Text = "Ты же вирус!";
                        button2.Text = "А я нет!";
                        break;
                    }
                case 11://
                    {
                        label1.Text = "Ах ты так?\n" + "Надо посильнее заразить компьютер.";
                        button1.Text = "Я ругаться буду.";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 12://
                    {
                        label1.Text = "И у меня хорошо!\n" + "Что делаешь?";
                        button1.Text = "Отдыхаю.";
                        button2.Text = "Работаю.";
                        break;
                    }
                case 13://
                    {
                        label1.Text = "Что случилось?\n" + "Работа достала? Да?";
                        button1.Text = "Да.";
                        button2.Text = "Нет.";
                        break;
                    }
                case 14://
                    {
                        label1.Text = "Я хочу дружить\n" + "";
                        button1.Text = "Ты вирус!";
                        button2.Text = "А я нет!";
                        break;
                    }
                case 15://
                    {
                        label1.Text = "Я знаю! Тебя звать Уйди?\n" + "";
                        button1.Text = "Нет";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 16://
                    {
                        label1.Text = "С тобой весело! ☺ ☺ ☺\n\n" + "Твой антивирус\n как-то странно смотрит на меня.";
                        button1.Text = "Тоже хочет дружить";
                        button2.Text = "Сейчас тебя удалит.";
                        break;
                    }
                case 17://
                    {
                        label1.Text = "Почему?\n" + "Хочешь, чтобы я заразил компьютер?";
                        button1.Text = "Нельзя!";
                        button2.Text = "НЕТ!";
                        break;
                    }
                case 18://
                    {
                        label1.Text = "Ну вот и хорошо!\n" + "Давай дружить?";
                        button1.Text = "Давай.";
                        button2.Text = "Нет.";
                        break;
                    }
                case 19://
                    {
                        label1.Text = "Даже если я обещаю\n" + "не заражать твой компьютер.";
                        button1.Text = "Да.";
                        button2.Text = "Ты вирус!";
                        break;
                    }
                case 20://
                    {
                        label1.Text = "А разве вирусы с человеками\n не могут дружить?";
                        button1.Text = "Нет.";
                        button2.Text = "Люди удаляют их.";
                        break;
                    }
                case 21://
                    {
                        label1.Text = "Вот сейчас заражу тебя!\n" + "";
                        button1.Text = "Нельзя!";
                        button2.Text = "Исчезни!";
                        break;
                    }
                case 22://
                    {
                        label1.Text = "А я тебя не боюсь!\n" + "";
                        button1.Text = "Я Олега позову.";
                        button2.Text = "Зря.";
                        break;
                    }
                case 23://
                    {
                        label1.Text = "Ну, пожалуйста!\n" + "";
                        button1.Text = "Нельзя.";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 24://
                    {
                        label1.Text = "И я отдыхаю!\n" + "Как настроение?";
                        button1.Text = "Отличное.";
                        button2.Text = "Плохое.";
                        break;
                    }
                case 25://
                    {
                        label1.Text = "От работы дохнут кони.\n" + "Ну, а ты бессмертный?";
                        button1.Text = "Пони.";
                        button2.Text = "Работаю.";
                        break;
                    }
                case 26://
                    {
                        label1.Text = "Так ты не работай.\n" + "";
                        button1.Text = "Надо.";
                        button2.Text = "Нельзя.";
                        break;
                    }
                case 27://
                    {
                        label1.Text = "Что случилось?\n" + "Работа достала? Да?";
                        button1.Text = "Да.";
                        button2.Text = "Нет.";
                        break;
                    }
                case 28:
                    {
                        label1.Text = "А ты человек!\n" + "Человеки дружат, а ты нет.\n";
                        button1.Text = "А ты вирус.";
                        button2.Text = "С вирусами нет";
                        break;
                    }
                case 29://
                    {
                        label1.Text = "Почему ты так со мной?\n" + "";
                        button1.Text = "Ты вирус!";
                        button2.Text = "Ты заразный";
                        break;
                    }
                case 30://
                    {
                        label1.Text = "А как тебя звать?\n" + "";
                        button1.Text = "Мне некогда.";
                        button2.Text = "Не важно.";
                        break;
                    }
                case 31://
                    {
                        label1.Text = "Привет, Уйди, я вирус! ☺\n" + "";
                        button1.Text = "Отстань.";
                        button2.Text = "Уйди!";
                        break;
                    }
                case 32:
                    {
                        label1.Text = "Правда?\n" + "Пойду с ним пообщаюсь! ☺";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 33:
                    {
                        label1.Text = "НЕТ!\n" + "Я же добрый вирус!\n\n Пожалуй, мне пора";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 34:
                    {
                        label1.Text = "Эх... Ладно...\n" + "Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 35:
                    {
                        label1.Text = "Дружить не хочешь.\n" + "Чтобы я заразил компьютер, не хочешь.\n Тогда я пойду.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 36:
                    {
                        label1.Text = "Замечательно!!!\n" + "Меня вирусная мама зовет.\n Потом еще поиграем.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 37:
                    {
                        label1.Text = "Грустно...\n" + "Тогда я пойду. Пока.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 38:
                    {
                        label1.Text = "Прости меня.\n" + "Я пойду?";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 39:
                    {
                        label1.Text = "А ты человек!\n" + "Человеки дружат, а ты нет.\n Эх... Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 40:
                    {
                        label1.Text = "Как грустно.\n Пока, человек.";
                        button1.Text = "Пока, вирус.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 41:
                    {
                        label1.Text = "Мне ... Я... \n Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 42:
                    {
                        label1.Text = "Эх... Ладно...\n" + "Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 43:
                    {
                        label1.Text = "Злюка ты!\n" + "Даже заражать не хочется.\n Я ухожу.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 44:
                    {
                        label1.Text = "Нет, нет.\n" + "Я уже ушел.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 45:
                    {
                        label1.Text = "Правда?\n" + "Можно я просто уйду?";
                        button1.Text = "Да.";
                        button2.Text = "Уйди.";
                        break;
                    }
                case 46:
                    {
                        label1.Text = "Эх... Ладно...\n" + "Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 47:
                    {
                        label1.Text = "Злюка ты!\n" + "Даже заражать не хочется.\n Я ухожу.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 48:
                    {
                        label1.Text = "Не буду больше отвлекать тебя.\n" + "Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 49:
                    {
                        label1.Text = "Сегодня же первое апреля!\n" + "Подшути над кем-нибудь.";
                        button1.Text = "Хорошо.";
                        button2.Text = "Не буду.";
                        break;
                    }
                case 50:
                    {
                        label1.Text = "Ха-ха! \n" + "Извини, что отвлекал. Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 51:
                    {
                        label1.Text = "Извини, что отвлекаю.\n" + "Пока";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 52:
                    {
                        label1.Text = "Чтобы деньги зарабатывать?\n" + "Тогда я не буду тебя отвлекать. \n Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 53:
                    {
                        label1.Text = "Работай.\n" + "Я пойду.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 54:
                    {
                        label1.Text = "Сделай перерыв! Ну вот, я тебе помог. ☺\n" + "Теперь надо идти помогать другим\n  Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 55:
                    {
                        label1.Text = "Я?\n" + "Тогда я пойду. Пока.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 56:
                    {
                        label1.Text = "Плохо, что вирусы с человеками не дружат.\n" + "Эх... пока, человек.\n";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 57:
                    {
                        label1.Text = "Вот ты как!\n" + "Уйду я от тебя!\n";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 58:
                    {
                        label1.Text = "Я обиделся.\n" + "Я ухожу!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 59:
                    {
                        label1.Text = "Злюка ты!\n" + "Даже заражать не хочется.\n Я ухожу.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 60:
                    {
                        label1.Text = "Эх... Ладно...\n" + "Пока!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 61:
                    {
                        label1.Text = "Злюка ты!\n" + "Даже заражать не хочется.\n Я ухожу.";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 62:
                    {
                        label1.Text = "Я обиделся.\n" + "Я ухожу!";
                        button1.Text = "Пока.";
                        button2.Text = "Удачи.";
                        break;
                    }
                case 63:
                    {
                        label1.Text = "Мне скучно с тобой.\n" + "Я пойду.";
                        button1.Text = "Пока.";
                        button2.Text = "Уйди!";
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = status * 2;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = status * 2 + 1;
            Close();

        }
    }
}

            
       