using laba;
using Laba;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(this);
        }
        public void Navigate(Form formFrom, Form formTo)
        {
            formFrom.Hide();

            formTo.ShowDialog();

            formFrom.Show();

        }
        public void SetStyle(Control element)
        {
            foreach (Control control in element.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }
        private void ToFirstExButton_Click(object sender, EventArgs e)
        {
            Ex1Form form = new Ex1Form();
            Navigate(this, form);
        }

        private void ToSecondExButton_Click(object sender, EventArgs e)
        {
            Ex2Form form = new Ex2Form();
            Navigate(this, form);
        }
    }
}
