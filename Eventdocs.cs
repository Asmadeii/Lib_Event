﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibEvent
{
    public partial class Eventdocs : Form
    {
        public Eventdocs()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct eDoc
        {
            public int scode;
            public int stcode;
            public string sname;
            public string sdate;
            public string saud;
            public string spll;

            public eDoc(int _scode, int _stcode, string _sname, string _sdate, string _saud, string _sppl)
            {
                scode = _scode;
                stcode = _stcode;
                sname = _sname;
                sdate = _sdate;
                saud = _saud;
                spll = _sppl;
            }
        }

        List<eDoc> edocs = new List<eDoc>();      

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events events = new Events();
            events.Show();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = EventList.CurrentCell.RowIndex;
            EventList.Rows.RemoveAt(rowIndex);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(codBox.Text, codTBox.Text, nameBox.Text, dataBox.Text, audBox.Text, pplBox.Text);
            EventList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Eventdocs_Load(object sender, EventArgs e)
        {            
            edocs.Add(new eDoc(3412, 1001, "Студенческий Stand-up", "05.02.2022", "От 15 до 30 лет", "До 25 человек"));
            edocs.Add(new eDoc(5231, 1001, "О подвигах, о доблести, о славе", "20.02.2022", "От 0 до 14 лет", "До 40 человек"));
            edocs.Add(new eDoc(4123, 1002, "Последний приют поэта", "12.03.2022", "От 0 до 14 лет", "До 40 человек"));
            edocs.Add(new eDoc(5624, 1001, "Волшебная школа Карандаша и Самоделкина", "22.03.2022", "От 0 до 14 лет", "До 25 человек"));
            edocs.Add(new eDoc(1451, 1003, "Зажги свою звезду", "09.04.2022", "От 0 до 14 лет", "До 40 человек"));
            edocs.Add(new eDoc(5298, 1002, "Культура победит тоску и грусть!", "20.04.2022", "От 0 до 14 лет", "До 40 человек"));
            edocs.Add(new eDoc(7841, 1001, "Вспомним всех поименно", "04.05.2022", "30 и выше", "До 40 человек"));
            edocs.Add(new eDoc(9834, 1003, "Вечер настольных игр", "17.05.2022", "От 15 до 30 лет", "До 25 человек"));

            table.Columns.Add("Код мероприятия", typeof(int));
            table.Columns.Add("Код вида мероприятия", typeof(int));
            table.Columns.Add("Наименование мероприятия", typeof(string));
            table.Columns.Add("Дата проведения", typeof(string));
            table.Columns.Add("Целевая аудитория", typeof(string));
            table.Columns.Add("Количество человек", typeof(string));

            for (int i = 0; i < edocs.Count; i++)
            {
                table.Rows.Add(edocs[i].scode, edocs[i].stcode, edocs[i].sname, edocs[i].sdate, edocs[i].saud, edocs[i].spll);
            }
            EventList.DataSource = table;
        }
    }
}
