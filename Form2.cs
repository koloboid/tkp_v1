using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKP_V1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var data = new List<DayReport>();
            var random = new Random();
            const int min = 5;
            const int max = 30;

            for (int i = 1; i <= 5; i++)
            {
                data.Add(new DayReport()
                {
                    Day = i,
                    Notebook = random.Next(min, max),
                    Notepad = random.Next(min, max),
                    Pen = random.Next(min, max),
                    Pencil = random.Next(min, max),
                });
            }
            chart1.DataSource = data;
        }
    }

    public class DayReport
    {
        public int Day
        {
            get;
            set;
        }
        public int Pen
        {
            get;
            set;
        }
        public int Pencil
        {
            get;
            set;
        }
        public int Notebook
        {
            get;
            set;
        }
        public int Notepad
        {
            get;
            set;
        }
    }
}
