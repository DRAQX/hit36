using System;

namespace hit36
{
    public partial class settingsWindow : Form
    {
        mainGameWindow gameWindow = new mainGameWindow();
        
        public settingsWindow()
        {
            InitializeComponent();
            // get init values from form on start!
        }

        private void settingsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
