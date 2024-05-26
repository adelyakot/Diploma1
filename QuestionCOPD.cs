using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace WindowsFormsApp_Diplom
{
    public class QuestCOPD
    {
        // показатели
        int age;
        DateTime birth_day;
        int sigar_day;
        int experience_smoke;
        int test_copd_score = 0;
        float weight;
        float height;
        float bmi;
        bool bad_weather_cough;//провоцирует ли плохая погода у вас кашель
        bool cough_sputum_outside_colds; //кашель с мокротой вне простудных заболеваний
        bool morning_sputum_cough;
        bool dyspnea; //одышка
        bool allergy;// аллергия
        string test_Result;

        public void set_BD(DateTime BD)
        {
            this.birth_day = BD;
            DateTime now = DateTime.Today;

            int age = now.Year - BD.Year;
            if (BD > now.AddYears(-age)) age--;
        }

        public void set_sigday (int sd)
        {
            this.sigar_day = sd;
        }

        public void set_exper_smoke(int expsmoke)
        { 
            this.experience_smoke = expsmoke;
        }

        public void set_weight(float w)
        {
            this.weight = w;
        }

        public void set_height(float h)
        {
            this.height = h;
        }

        public void set_bad_weather_cough(bool a)
        {
            this.bad_weather_cough = a;
        }

        public void set_cough_sputum_outside_colds(bool a)
        {
            this.cough_sputum_outside_colds = a;
        }

        public void set_morning_sputum_cough(bool a)
        {
            this.morning_sputum_cough = a;
        }

        public void set_dyspnea(bool a)
        {
            this.dyspnea = a;
        }

        public void set_allergy(bool a)
        {
            this.allergy = a;
        }


        public int get_test_copd_score() { return test_copd_score; }
        //bool bad_weather_cough;//провоцирует ли плохая погода у вас кашель
        //bool cough_sputum_outside_colds; //кашель с мокротой вне простудных заболеваний
        //bool morning_sputum_cough;
        //bool dyspnea; //одышка
        //bool allergy;// аллергия

        public bool test_copd()
           {
           test_copd_score = 0;
            bmi = (weight)/(height/100 * height/100);
            int pachka_let = (sigar_day / 20) * experience_smoke; 

            //возраст баллы
            
                if (age >= 50 && age <= 59)
                    test_copd_score += 4;
                else if (age >= 60 && age <= 69)
                    test_copd_score = 8;
                else if (age >= 70)
                    test_copd_score += 10;
            

            // количество пачка лет
            
                if (pachka_let >= 15 && pachka_let <= 24)
                    test_copd_score += 2;
                else if (pachka_let >= 25 && pachka_let <= 49)
                    test_copd_score += 3;
                else if (pachka_let >= 50)
                    test_copd_score += 7;
            

            // индекс массы тела
            
                if (bmi < 25.4)
                    test_copd_score += 5;
                else if (bmi >= 25.4 && bmi <= 29.7)
                    test_copd_score += 1;
                else if (bmi > 29.7)
            

            if (bad_weather_cough) test_copd_score += 3;
            if (cough_sputum_outside_colds) test_copd_score += 3;
            if (morning_sputum_cough) test_copd_score += 3;
            if (dyspnea) test_copd_score += 4;
            if (allergy) test_copd_score += 3;

            if (test_copd_score >= 17)
            {
                test_Result = "Диагноз ХОБЛ вероятен.";
                return true;
            }
            else {
                test_Result = "Рассмотрите другие заболевания, включая бронхиальную астму";
                return false;

            }
        }
    }
}
