using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz07._04._2023 {
    public partial class Form4 : Form {
        Form2 form2;
        Form3 form3;
        public Form ParentForm { get; set; }
        public Form4() => InitializeComponent();
        private void check3_Click(object sender, EventArgs e) {
            label10.Text = $"0.0 грн";
        }
    }
}
