using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pytaniaBadowski4c
{
    public partial class Form1 : Form
    {
        class pytanie
        {
            public string tresc { get; set; }
            public string[] odpowiedzi { get; set; }
            //public int poprawnaOdp { get; set; }

        }
        List<pytanie> pytania = new List<pytanie>();
        string[] linie = File.ReadAllLines("pytania.txt");
        Label[] wys;
        CheckBox[] wyb;
        public Form1()
        {
            InitializeComponent();
            loadQuestions();
        }
        void loadQuestions()
        {
            using (var sr = new StreamReader("pytania.txt"))
            {
                for (int i = 1; i < lines; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }

            /*int j = 0;
            for(int i = 0; i < linie.Length; i++)
            {
                if(i == 0 || i % 5 == 0)
                {
                    pytania[j] = new pytanie { tresc = linie[i] };
                    j++;
                }
            }
            j = 0;
            int m = 0;
            for(int i = 1; i < linie.Length; i++)
            {
                if(i % 5 == 0)
                {
                    m = 0;
                    continue;
                } else
                {
                    pytania[j].odpowiedzi[m] = linie[i];
                    m++;
                    j++;
                }
            }
            wys = new Label[pytania.Count];
            wyb = new CheckBox[pytania.Count * 4];
            string[] odp = new string[4] { "A)", "B)", "C)", "D)" };
            int x = 0;
            int y = 0;
            int l = 0;
            for(int i = 0; i < pytania.Count; i++)
            {
                wys[i] = new Label();
                wys[i].Text = (i+1).ToString() + pytania[i].tresc;
                wys[i].Location = new Point(x, y);
                wys[i].Width = 500;
                wys[i].Height = 100;
                wys[i].Font = new Font("Segoe UI", 20);
                Controls.Add(wys[i]);
                for (int k = l; k < l+4; k++)
                {
                    wyb[k].Text = pytania[i].odpowiedzi[k];
                    wyb[k].Width = 200;
                    wyb[k].Height = 50;
                    wyb[k].Tag = odp[k];
                    Controls.Add(wyb[k]);
                }
                l += 4;
                y += 350;*/
        }
        }
    }
}