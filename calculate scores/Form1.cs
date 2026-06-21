namespace calculate_scores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            var visa = visanumericUpDown.Value;
            var assignment = assignmentnumericUpDown1.Value;
            var final = finalnumericUpDown.Value;

            var avarage = visa * .3m + assignment * .2m + final * .5m;
            avarageresultlabel.Text = avarage.ToString("N2");

            resultresultlabel.Text = avarage >= 50 ? "passed" : "failed";
        }
    }
}
