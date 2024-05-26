using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace WindowsFormsApp_Diplom
{
    public class Question
    {
        public Question(string n, List<string> a)
        {
            name = n;
            answers = a;

        }
        public string name;
        public List<string> answers;



    }
    public class Symptom
    {
        public Symptom(Question q, int a)
        {
            this.ansind = a;
            this.ques = q;
        }
        public int ansind;
        public Question ques;

        public Question get_question() { return ques; }
    }


    public class Result
    {
        public Result(string n)//, string l, string p)
        {
            name = n;
        }
        public string name;

        public string get_name()
        {
            return name;
        }

        public void set_name(string n)
        {
            name = n;
        }  
    }



    public class Diagnosis
    {
        public List<Symptom> symptoms;
        public List<Result> results;
        public Diagnosis(List<Symptom> symp, List<Result> r)
        {
            this.symptoms = symp;
            this.results = r;

        }
    }

    public class ExpertSystem
    {

        public List<Diagnosis> Rules;
      
        public List<Symptom> Symptoms;
        public int ca;
        public int i = 0;
        public int j = 0;

        public List<Symptom> tempDB = new List<Symptom> { };


        public ExpertSystem()
        {
            Rules = new List<Diagnosis>();
        }


        public List<Symptom> getDB()
        {
            return this.tempDB;
        }
        

        void set_rules(List<Diagnosis> rules)
        {
            this.Rules = rules;
        }

        void set_symptoms(List<Symptom> symptoms)
        {
            this.Symptoms = symptoms;
        }


        public void AddRule(Diagnosis rule)
        {
            Rules.Add(rule);
        }

        public Diagnosis FindMatchingRule(Dictionary<Question, int> answers)
        {
            foreach (var rule in Rules)
            {
                bool isMatching = true;
                foreach (var symptom in rule.symptoms)
                {
                    if (symptom.ansind != answers[symptom.ques])
                    {
                        isMatching = false;
                        break;
                    }
                }
                if (isMatching)
                {
                    return rule;
                }
            }
            return null;
        }







        public void createES()
        {
            Question q1 = new Question("Баллы вопросника ХОБЛ >= 17?", new List<string> { "<= 16", ">= 17" });
            Question q2 = new Question("Постбронходилатационный ОФВ1/ФЖЕЛ < 0.7?", new List<String> { "Да", "Нет" });
            Question q3 = new Question("Диффузионная способность легких < 80% ?", new List<string> { "Да", "Нет" });
            Question q4 = new Question("Пациент курит?", new List<string> { "Да", "Нет" });
            Question q5 = new Question("Бронхиальная обструкция обратима? ", new List<string> { "Да", "Нет" }); //1 эмфизематозный будет, 2 брохитический
            Question q6 = new Question("Повышенное количество нейтрофилов, макрофагов, Т-лимфоцитов или эозинофилов?", new List<string> { "Да", "Нет" });
            Question q7 = new Question("Пациент моложе 45 лет, или симптомы быстро прогрессируют, или есть эмфизема (преимущественно в базальных отделах легких?)", new List<string> { "Да", "Нет" });
            Question q8 = new Question("Есть дефицит альфа1-антитрипсина?", new List<string> { "Да", "Нет" });
            Question q9 = new Question("Легочная функция в результате лечения ингаляционными глюкокортикостероидами (ИГКС) нормализовалась?", new List<string> { "Да", "Нет" });
            //set_questions(new List<Question> { q1, q2, q3, q4, q4, q5, q6,q7, q8, q9});

            Result r1 = new Result("Нет оснований диагностировать ХОБЛ");
            Result r2 = new Result("Повышенный риск развития ХОБЛ со временем");
            Result r3 = new Result("Проведите обследование для исключения хронической сердечной недостаточности (ХСН)");
            Result r4 = new Result("Рассмотрите другие заболевания, включая бронхиальную астму, или направьте к специалисту.");
            Result r5 = new Result("Рекомендуется отказаться от диагноза ХОБЛ в пользу БА");
            Result r6 = new Result("ХОБЛ");



            Symptom s11 = new Symptom(q1, 0);
            Symptom s12 = new Symptom(q1, 1);

            Symptom s21 = new Symptom(q2, 0);
            Symptom s22 = new Symptom(q2, 1);

            Symptom s31 = new Symptom(q3, 0);
            Symptom s32 = new Symptom(q3, 1);

            Symptom s41 = new Symptom(q4, 0);
            Symptom s42 = new Symptom(q4, 1);

            Symptom s51 = new Symptom(q5, 0);
            Symptom s52 = new Symptom(q5, 1);

            Symptom s61 = new Symptom(q6, 0);
            Symptom s62 = new Symptom(q6, 1);

            Symptom s71 = new Symptom(q7, 0);
            Symptom s72 = new Symptom(q6, 1);

            Symptom s81 = new Symptom(q8, 0);
            Symptom s82 = new Symptom(q8, 1);

            Symptom s91 = new Symptom(q9, 0);
            Symptom s92 = new Symptom(q9, 1);

            set_symptoms(new List<Symptom> { s11, s12, s21, s22, s31, s32, s41, s42, s51, s52, s61, s62, s71, s72, s81, s82, s91, s92 });


            Diagnosis d1 = new Diagnosis(new List<Symptom> { s11 }, new List<Result> { r4 });
            Diagnosis d2 = new Diagnosis(new List<Symptom> { s12, s21, s51, s61, s71, s81, s91 }, new List<Result> { r5 });
            Diagnosis d3 = new Diagnosis(new List<Symptom> { s12, s21, s51, s61, s71, s81, s92 }, new List<Result> { r6 });
            Diagnosis d4 = new Diagnosis(new List<Symptom> { s12, s21, s51, s61, s71, s82 }, new List<Result> { r4 });
            Diagnosis d5 = new Diagnosis(new List<Symptom> { s12, s21, s51, s61, s72, s91 }, new List<Result> { r5 });
            Diagnosis d6 = new Diagnosis(new List<Symptom> { s12, s21, s51, s61, s72, s92 }, new List<Result> { r6 });
            Diagnosis d7 = new Diagnosis(new List<Symptom> { s12, s21, s51, s62 }, new List<Result> { r4 });
            Diagnosis d8 = new Diagnosis(new List<Symptom> { s12, s21, s52, s61, s71, s81, s91 }, new List<Result> { r5 });
            Diagnosis d9 = new Diagnosis(new List<Symptom> { s12, s21, s52, s61, s71, s81, s92 }, new List<Result> { r6 });
            Diagnosis d10 = new Diagnosis(new List<Symptom> { s12, s21, s52, s61, s71, s82 }, new List<Result> { r4 });
            Diagnosis d11 = new Diagnosis(new List<Symptom> { s12, s21, s52, s61, s72, s91 }, new List<Result> { r5 });
            Diagnosis d12 = new Diagnosis(new List<Symptom> { s12, s21, s52, s61, s72, s92 }, new List<Result> { r6 });
            Diagnosis d13 = new Diagnosis(new List<Symptom> { s12, s21, s52, s62 }, new List<Result> { r4 });
            Diagnosis d14 = new Diagnosis(new List<Symptom> { s12, s22, s31, s41 }, new List<Result> { r2 });
            Diagnosis d15 = new Diagnosis(new List<Symptom> { s12, s22, s31, s42 }, new List<Result> { r3 });
            Diagnosis d16 = new Diagnosis(new List<Symptom> { s12, s22, s32 }, new List<Result> { r1 });


            set_rules(new List<Diagnosis> { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16 });
        }


        public void checkans(Label tb, Label res, Button bt1, Button bt2)
        {
           
            if (Rules[i].symptoms[j].ansind == ca)
            {
                tempDB.Add(Rules[i].symptoms[j]);
                j++;
            }
            else
            {
                Symptom s = new Symptom(Rules[i].symptoms[j].ques, ca);
                tempDB.Add(s);
                j = 0;
                i++;
            }
            update(tb, res, bt1, bt2);
        }

        public void update(Label tb,Label res,  Button bt1, Button bt2)
        {
            if (tempDB.Count == 0)
            {
                tb.Text = Rules[i].symptoms[j].ques.name;
                bt1.Text = Rules[i].symptoms[j].ques.answers[0];
                bt2.Text = Rules[i].symptoms[j].ques.answers[1];
            }
            else
            {
                while (true)
                {
                    while (j < tempDB.Count && Rules[i].symptoms[j].ques.name == tempDB[j].ques.name && Rules[i].symptoms[j].ansind == tempDB[j].ansind) j++;
                    if (j < tempDB.Count)
                    {
                        j = 0;
                        i++;
                    }
                    else if (j == tempDB.Count && j < Rules[i].symptoms.Count)
                    {
                        tb.Text = Rules[i].symptoms[j].ques.name;
                        bt1.Text = Rules[i].symptoms[j].ques.answers[0];
                        bt2.Text = Rules[i].symptoms[j].ques.answers[1];
                        break;
                    }
                    else
                    {
                        //res.Text = Rules[i].results[0].name;
                        //tb.Hide();
                        //bt1.Hide();
                        //bt2.Hide();
                        //res.Show();
                        showres(tb, res, bt1, bt2);
                        break;
                    }
                }
            }

        }

        public void restart(Button restart, Label tb,  Label res,  Button bt1, Button bt2)
        {
            if (restart.Text == "Заново")
            {
                i = 0;
                j = 0;
                tempDB.Clear();
                update(tb, res, bt1, bt2);
                tb.Show();
                res.Hide();               
                bt1.Show();
                bt2.Show();
            }
            else
            {
                res.Hide();
                tb.Show();
                bt1.Show();
                bt2.Show();
                restart.Text = "Заново";
                update(tb, res, bt1, bt2);
            }
        }


        public void showres( Label tb, Label res, Button bt1, Button bt2)
        {
            bt1.Hide();
            tb.Hide();
            bt2.Hide();
            res.Show();
            res.Text = Rules[i].results[0].name;
        }

    }

}
