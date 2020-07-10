using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefactoringExercise
{
    public partial class FrmRefactoring : Form
    {

        public FrmRefactoring()
        {
            InitializeComponent();
        }

        private void FrmRefactoring_Load(object sender, EventArgs e)
        {
            TxtInput.Text = "";
            TxtNum01.Text = "";
            TxtNum02.Text = "";
            TxtNum03.Text = "";
            TxtNum04.Text = "";
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtInput.Text);

            int square = num * num;
            int cube = num * num * num;
            int quartic = num * num * num * num;
            int sum = square + cube + quartic;

            TxtNum01.Text = square.ToString();
            TxtNum02.Text = cube.ToString();
            TxtNum03.Text = quartic.ToString();
            TxtNum04.Text = sum.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtInput.Text = "";
            TxtNum01.Text = "";
            TxtNum02.Text = "";
            TxtNum03.Text = "";
            TxtNum04.Text = "";
        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtInput.Text);

            int square = num + num;
            int cube = num + num + num;
            int quartic = num + num + num + num;
            int sum = square + cube + quartic;

            TxtNum01.Text = square.ToString();
            TxtNum02.Text = cube.ToString();
            TxtNum03.Text = quartic.ToString();
            TxtNum04.Text = sum.ToString();
        }
    }
}
