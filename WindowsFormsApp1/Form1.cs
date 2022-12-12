using Motorcicos;
using Motorcicos.Motores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<IMotor> lista = new List<IMotor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxTipos.DataSource = MotorFactoryReflexion.Automatico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMotor motor = MotorFactoryReflexion.CreateInstance(this.comboBoxTipos.SelectedItem.ToString());
            lista.Add(motor);
            foreach (var item in lista)
            {
                MessageBox.Show(item.ToString());
            }
        }

    }
}
