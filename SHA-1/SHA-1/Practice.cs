using SHA1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA1
{
    public partial class Practice : Form
    {

        List<Question> questions = new List<Question>();
        Button btn = new Button();
        public Practice()
        {
            InitializeComponent();



            Question q2 = new Question("Криптографічна хеш-функція – це…", 1, false);
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає визначений блок даних і повертає рядок встановленого розміру", false, "");
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає визначений блок даних і повертає рядок не встановленого розміру", false, "");
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає довільний блок даних і повертає рядок встановленого розміру", true, "Правильно!");
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає довільний блок даних і повертає рядок не встановленого розміру", false, "");
            GroupBox grp = q2.buildAnswer("#1");
            grp.Location = new Point(30, 70);
            Controls.Add(grp);
            questions.Add(q2);

            Question q3 = new Question("Яка особливість хеш-функцій?", 1, false);
            q3.addAnswer("зміни даних змінять хеш-значення", true, "Правильно!");
            q3.addAnswer("зміни даних не змінять хеш-значення", false, "");
            q3.addAnswer("можливо знайти два різних повідомлення з тим самим хешем", false, "");
            q3.addAnswer("хеш-функцiї не особливi", false, "");
            GroupBox grp3 = q3.buildAnswer("#2");
            grp3.Location = new Point(grp.Left, grp.Bottom + 10);
            Controls.Add(grp3);
            questions.Add(q3);

            Question q4 = new Question("Коли був розроблений та опублікований SHA-1 алгоритм?", 1, false);
            q4.addAnswer("1993", true, "Правильно!");
            q4.addAnswer("1992", false, "");
            q4.addAnswer("2017", false, "");
            q4.addAnswer("1996", false, "");
            GroupBox grp4 = q4.buildAnswer("#3");
            grp4.Location = new Point(grp3.Left, grp3.Bottom + 10);
            Controls.Add(grp4);
            questions.Add(q4);

            Question q5 = new Question("Повідомлення якої довжини алгоритм отримує на вході?", 1, false);
            q5.addAnswer("160", false, "");
            q5.addAnswer("264", true, "Правильно!");
            q5.addAnswer("448", false, "");
            q5.addAnswer("512", false, "");
            GroupBox grp5 = q5.buildAnswer("#4");
            grp5.Location = new Point(grp4.Left, grp4.Bottom + 10);
            Controls.Add(grp5);
            questions.Add(q5);


            Question q6 = new Question("Яка довжина дайджеста?", 1, false);
            q6.addAnswer("159", false, "");
            q6.addAnswer("512", false, "");
            q6.addAnswer("1", false, "");
            q6.addAnswer("160", true, "Правильно!");
            GroupBox grp6 = q6.buildAnswer("#5");
            grp6.Location = new Point(grp5.Left, grp5.Bottom + 10);
            Controls.Add(grp6);
            questions.Add(q6);

            Question q7 = new Question("Скільки 32-бітних регістрів використовується при ініціалізації SHA-1 буфера?", 1, false);
            q7.addAnswer("2", false, "");
            q7.addAnswer("5", true, "Правильно!");
            q7.addAnswer("9", false, "");
            q7.addAnswer("12", false, "");
            GroupBox grp7 = q7.buildAnswer("#6");
            grp7.Location = new Point(grp6.Left, grp6.Bottom + 10);
            Controls.Add(grp7);
            questions.Add(q7);

            Question q8 = new Question("Чи завжди виконується додавання відсутніх бітів?", 1, false);
            q8.addAnswer("Ні, якщо повідомлення має потрібну довжину", false, "");
            q8.addAnswer("Так, навіть якщо повідомлення має потрібну довжину", true, "Правильно!");
            GroupBox grp8 = q8.buildAnswer("#7");
            grp8.Location = new Point(grp7.Left, grp7.Bottom + 10);
            Controls.Add(grp8);
            questions.Add(q8);

            Question q9 = new Question("В якомі діапазоні знаходиться число додатніх бітів?", 1, false);
            q9.addAnswer("(1; 448)", false, "");
            q9.addAnswer("(1; 0)", false, "");
            q9.addAnswer("(1; 512)", true, "Правильно!");
            q9.addAnswer("(1; 511)", false, "");
            GroupBox grp9 = q9.buildAnswer("#8");
            grp9.Location = new Point(grp8.Left, grp8.Bottom + 10);
            Controls.Add(grp9);
            questions.Add(q9);

            Question q10 = new Question("Додавання складається з … ", 1, false);
            q10.addAnswer("Одиниці і потрібної кількості нулів ", true, "Правильно!");
            q10.addAnswer("Одиниць і нулів які чергуються", false, "");
            q10.addAnswer("Нуля і потрібної кількості одиниць", false, "");
            q10.addAnswer("Одиниці і кількох нулів", false, "");
            GroupBox grp10 = q10.buildAnswer("#10");
            grp10.Location = new Point(grp9.Left, grp9.Bottom + 10);
            Controls.Add(grp10);
            questions.Add(q10);

            Label lb = new Label();
            lb.Height = 30;



            btn.Text = "Перевiрити";
            btn.Width = 100;
            btn.Height = 30;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Location = new Point(ClientSize.Width/2 - btn.Width/2, grp10.Bottom + 40);
            lb.Location = new Point(ClientSize.Width / 2 - btn.Width / 2, btn.Bottom);

            btn.Click += Btn_Click;
            Controls.Add(btn);
            Controls.Add(lb);



            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int score = 0;
            int maxScore = 0;
            int correctAnswers = 0;
            foreach (Question q in questions)
            {
                int sc = q.getScore();
                score += sc;
                if (sc > 0)
                    correctAnswers++;
                maxScore += q.score;
            }

            var maess = "UserName: " +  Environment.UserName + "\nВи маєте оцінку " + score + " з " + maxScore + " можливих, відповівши правильно на " + correctAnswers + " запитань";
            MessageBox.Show(maess);

        }
    }
}
