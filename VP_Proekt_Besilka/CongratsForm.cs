using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_Besilka
{
    public partial class CongratsForm : Form
    {
        public CongratsForm(int points)
        {
            InitializeComponent();
            labelPoints.Text = points.ToString();
        }
    }
}
