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
    public partial class Form1 : Form
    {
        public Game newGame { set; get; }
        public Category selectedCategory { set; get; }

        public Form1()
        {
            InitializeComponent();
            newGame = new Game();
            listBoxCategories.DataSource = newGame.Categories;
            listBoxCategories.DisplayMember = "Name";
            listBoxCategories.ValueMember = "Id";
        }

        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            selectedCategory = listBoxCategories.SelectedItem as Category;
            PlayGame newGame = new PlayGame(this);
            newGame.Show();
        }
    }
}
