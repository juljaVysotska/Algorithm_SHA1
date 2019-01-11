using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA1
{
    class Question
    {
        public string question { get; private set; }
        public bool isRelation { get; private set; }
        private Dictionary<string, bool> answers = new Dictionary<string, bool>();
        private Dictionary<string, string> explanations = new Dictionary<string, string>();
        private Dictionary<string, string> relationAnswers = new Dictionary<string, string>();
        public int score { get; private set; }
        GroupBox grp = new GroupBox();
        Random rnd = new Random();

        public Question(string questionToAsk, int scoreForAnswer, bool isRelationable)
        {
            question = questionToAsk;
            score = scoreForAnswer;
            isRelation = isRelationable;
        }

        public void addAnswer(string answer, bool isCorrect, string exp)
        {
            if (isRelation)
                MessageBox.Show("Вопрос \"" + question + "\" на соотношение, а вы пытаетесь добавить ответ.");
            else
            {
                try
                {
                    answers.Add(answer, isCorrect);
                    explanations.Add(answer, exp);
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show("Ответ \"" + answer + "\" уже был добавлен в вопрос \"" + question + "\"\n\n" + e, "Ошибка");
                }
            }
        }

        public void addRelation(string question, string answer)
        {
            if (isRelation)
            {
                try
                {
                    relationAnswers.Add(question, answer);
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show("Ответ \"" + answer + "\" уже был добавлен в вопрос \"" + question + "\"\n\n" + e, "Ошибка");
                }
            }
            else
                MessageBox.Show("Вопрос \"" + question + "\" не на соотношение, а вы пытаетесь его добавить.");
        }

        public GroupBox buildAnswer(string groupBoxText)
        {
            GroupBox result = new GroupBox();
            result.Text = groupBoxText;
            result.AutoSize = true;
            result.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Label q = new Label();
            q.Text = question + ". Балiв: " + score;
            q.AutoSize = true;
            q.Location = new Point(5, 15);
            result.Controls.Add(q);
            if (isRelation)
            {
                List<string> awailibleQuestions = new List<string>();
                List<string> awailibleAnswers = new List<string>();
                List<string> tempAnswers = new List<string>();

                foreach (KeyValuePair<string, string> a in relationAnswers)
                {
                    awailibleAnswers.Add(a.Value);
                }
                foreach (KeyValuePair<string, string> a in relationAnswers)
                {
                    awailibleQuestions.Add(a.Key);
                }
                for (int i = 0; i < 5; i++)
                {
                    int rand = rnd.Next(0, awailibleAnswers.Count);
                    while (tempAnswers.Contains(awailibleAnswers[rand]))
                        rand = rnd.Next(0, awailibleAnswers.Count);
                    tempAnswers.Add(awailibleAnswers[rand]);
                }

                for (int i = 0; i < relationAnswers.Count; i++)
                {
                    int rand = rnd.Next(0, awailibleAnswers.Count);

                    Label l = new Label();
                    l.AutoSize = true;
                    l.Name = awailibleAnswers[rand];
                    l.Text = (i + 1) + ". " + awailibleQuestions[rand];
                    l.Location = new Point(q.Location.X, q.Bottom + l.Height * i);
                    result.Controls.Add(l);

                    //rand = rnd.Next(0, awailibleAnswers.Count);

                    ComboBox c = new ComboBox();
                    c.Width = 35;
                    c.DropDownStyle = ComboBoxStyle.DropDownList;
                    for (int j = 1040; j < tempAnswers.Count + 1040; j++)
                    {
                        c.Items.Add(Convert.ToChar(j));
                    }
                    c.Name = Convert.ToChar(tempAnswers.IndexOf(relationAnswers[awailibleQuestions[rand]]) + 1040).ToString();
                    l.Name = c.Name;
                    c.Left = l.Right + 5;
                    c.Top = l.Top;
                    result.Controls.Add(c);

                    Label la = new Label();
                    la.AutoSize = true;
                    la.Name = tempAnswers[i];
                    la.Text = Convert.ToChar(i + 1040) + ". " + tempAnswers[i];
                    la.Top = l.Top;
                    la.Left = Math.Max(100, c.Right + 5);
                    result.Controls.Add(la);

                    awailibleAnswers.RemoveAt(rand);
                    awailibleQuestions.RemoveAt(rand);
                }
            }
            else
            {
                List<string> awailibleAnswers = new List<string>();

                foreach (KeyValuePair<string, bool> a in answers)
                {
                    awailibleAnswers.Add(a.Key);
                }

                for (int i = 0; i < answers.Count; i++)
                {
                    RadioButton r = new RadioButton();
                    r.AutoSize = true;
                    int rand = rnd.Next(0, awailibleAnswers.Count);
                    r.Name = awailibleAnswers[rand];
                    r.Text = (i + 1) + ". " + awailibleAnswers[rand];
                    r.Location = new Point(q.Location.X, q.Bottom + r.Height * i);
                    result.Controls.Add(r);
                    awailibleAnswers.RemoveAt(rand);
                }
            }
            grp = result;
            return result;
        }

        public int getScore()
        {
            int sc = 0;
            bool isChecked = false;
            if (isRelation)
            {
                foreach (Control cntrl in grp.Controls)
                {
                    if (cntrl is ComboBox)
                    {
                        ComboBox c = (ComboBox)cntrl;
                        if (c.Name == c.Text) //правильное соотношение
                        {
                            foreach (Control cn in grp.Controls)
                            {
                                if (cn is Label)
                                {
                                    Label lab = (Label)cn;
                                    if (lab.Name == c.Name)
                                    {
                                        lab.BackColor = Color.Green;
                                        sc += score / relationAnswers.Count();//можешь добавлять очки при каждом правильном соотношении. Написанный вариант работает криво - даёт баллы/кол-во ответов. 10/5 = 2, 9/5 = 1
                                    }
                                }
                            }
                        }
                        else //не правильное соотношение
                        {
                            foreach (Control cn in grp.Controls)
                            {
                                if (cn is Label)
                                {
                                    Label lab = (Label)cn;
                                    if (lab.Name == c.Name)
                                    {
                                        lab.BackColor = Color.Red;
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else
            {
                RadioButton cR = new RadioButton();
                foreach (Control cntrl in grp.Controls)
                {
                    if (cntrl is RadioButton)
                    {
                        RadioButton rdb = (RadioButton)cntrl;
                        if (rdb.Checked)
                        {
                            isChecked = true;
                            if (answers[rdb.Name])
                            {
                                grp.BackColor = Color.Green;//Правильный ответ
                                sc = score;
                            }
                            else
                                grp.BackColor = Color.Red;//Не правильный ответ
                        }
                        if (answers[rdb.Name])
                            cR = rdb;
                    }
                }
                if (!isChecked)
                    grp.BackColor = Color.Yellow; //Ответ не выбран
                if (grp.BackColor == Color.Red)
                {
                    cR.BackColor = Color.Green;
                    int i = 0;
                    foreach (Control cntrl in grp.Controls)
                    {
                        if (cntrl is RadioButton)
                        {
                            i++;
                            RadioButton rdb = (RadioButton)cntrl;
                            rdb.Text = i + ". " + rdb.Name + " (" + explanations[rdb.Name] + ")";
                        }
                    }
                }
                else
                {
                    int i = 0;
                    foreach (Control cntrl in grp.Controls)
                    {
                        if (cntrl is RadioButton)
                        {
                            i++;
                            RadioButton rdb = (RadioButton)cntrl;
                            rdb.Text = i + ". " + rdb.Name;
                        }
                    }
                }
            }
            return sc;
        }
    }
}
