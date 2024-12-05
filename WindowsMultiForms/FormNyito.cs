using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMultiForms
{
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // példányosítottuk a Form1 osztályt
            this.Hide(); // elrejtettük a FormNyito ablakot
            form1.Show(); // megjelenítettük a Form1 ablakot
            form1.FormClosed += (sendObject, args) =>
            {
                //-- eltávolítjuk a lehetséges hivatkozásokat a Form1 objektumra
                form1.Dispose(); // lefoglalt erőforrások felszabadítása
                form1 = null; // semmivé tesszük a Form1 objektumot
                GC.Collect(); // szemétgyűjtő futtatása
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // példányosítottuk a Form2 osztályt
            form2.ShowDialog(); // megjelenítettük a Form2 modal ablakot
        }
    }
}
