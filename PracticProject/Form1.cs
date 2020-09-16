using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Цвет". При необходимости она может быть перемещена или удалена.
            this.цветTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Цвет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Сделка". При необходимости она может быть перемещена или удалена.
            this.сделкаTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Сделка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Салон". При необходимости она может быть перемещена или удалена.
            this.салонTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Салон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Паспорт". При необходимости она может быть перемещена или удалена.
            this.паспортTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Паспорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Модель". При необходимости она может быть перемещена или удалена.
            this.модельTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Модель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Комплектация". При необходимости она может быть перемещена или удалена.
            this.комплектацияTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Комплектация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Акции". При необходимости она может быть перемещена или удалена.
            this.акцииTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Акции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Автомобиль);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = автомобильBindingSource;
        }

        private void акцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = акцииBindingSource;
        }

        private void TSMn3_Click(object sender, EventArgs e)
        {

        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = должностьBindingSource;
        }

        private void комплектацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = комплектацияBindingSource;
        }

        private void модельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = модельBindingSource;
        }

        private void паспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = паспортBindingSource;
        }

        private void салонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = салонBindingSource;
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = сделкаBindingSource;
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = сотрудникBindingSource;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = цветBindingSource;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          
        }
    }
}
