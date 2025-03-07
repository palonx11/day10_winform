using System.Data;

namespace _7._2._68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = question_text.Text;
            DataTable table = new DataTable();
            var c = table.Compute(gettext, null);
            solution_textbox.Text = c.ToString();
            solution_label.Text = c.ToString();
        }

        private void question_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void solution_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
