﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sothu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = String.Format("Bay gio la {0}:{1}:{2} ngay {3} thang {4} nam {5}.",
                                            DateTime.Now.Hour,
                                            DateTime.Now.Minute,
                                            DateTime.Now.Second,
                                            DateTime.Now.Day,
                                            DateTime.Now.Month,
                                            DateTime.Now.Year);
        }

        private void mnuload_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("D:\\thumoi.txt");
            if (reader == null) return;
            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                lstthumoi.Items.Add(input);
            }
            reader.Close();

            using (StreamReader rs = new StreamReader("D:\\danhsachthu.txt"))
            {
                input = null;
                while ((input = rs.ReadLine()) != null)
                {
                    lstdanhsach.Items.Add(input);
                }
            }
        }

        private void btnsave(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("D:\\danhsachthu.txt");

            if (writer == null) return;

            foreach (var item in lstdanhsach.Items)
                writer.WriteLine(item.ToString());

        }

        private void ListBox_mousedown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);

            lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Copy);
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;
        }

    }
}
