using System;
using System.Windows.Forms;
using Console.Lib;

namespace WindowsFormsApplication1
{
    public partial class ConsoleGUI : Form
    {
        public ConsoleGUI()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ConsoleHelper CH = new ConsoleHelper();
            Results.Text = CH.ExecuteCommands(Commands.Text);
            Errors.Text = CH.LastError;
        }
    }
}
