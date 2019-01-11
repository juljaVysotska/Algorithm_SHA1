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

namespace SHA_1
{
    public partial class Practice : Form
    {

        List<Question> questions = new List<Question>();
        public Practice()
        {
            InitializeComponent();



            Question q2 = new Question("Криптографічна хеш-функція – це…", 1, false);
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає визначений блок даних і повертає рядок встановленого розміру", false, "");
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає визначений блок даних і повертає рядок не встановленого розміру", false, "");
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає довільний блок даних і повертає рядок встановленого розміру", true, "Правильно!");
            q2.addAnswer("це хеш-функція, яка є алгоритмом, що приймає довільний блок даних і повертає рядок не встановленого розміру", false, "");
            GroupBox grp = q2.buildAnswer("#1");
            grp.Location = new Point(30, 60);
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
            GroupBox grp4 = q3.buildAnswer("#3");
            grp4.Location = new Point(grp3.Left, grp3.Bottom + 10);
            Controls.Add(grp4);
            questions.Add(q4);




        }

        
        
    }
}
