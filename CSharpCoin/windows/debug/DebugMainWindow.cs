using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCoin.windows.debug
{
    public partial class DebugMainWindow : Form
    {

        private String data;
        private String commandText;

        public DebugMainWindow()
        {
            InitializeComponent();

            InsertHeader();
        }

        // Caso seja pressionado o Enter, o programa dispara a ação...
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertDataFromInput();
                VerifyCommand(data);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Insere o Cabeçalho Inicial no RichTextBox (txtOutput)
        private void InsertHeader()
        {
            String[] title = { "             --------------- CSharpCoin - Debug Console --------------- \n"};

            for (int i = 0; i < title.Length; i++)
            {
                txtOutput.AppendText(title[i]);
            }
        }

        // Insere dados do TextBox (txtInput) no RichTextBox (txtOutput)
        private void InsertDataFromInput()
        {
            data = txtInput.Text; // Insere os dados do TextBox na variável GLOBAL
            txtOutput.AppendText(" " + data + "\n");
            txtInput.Text = ""; // Zera o TextBox
        }

        private void VerifyCommand(String data)
        {
            if (data.Equals("help"))
            {
                commandText = " test \n";
                txtOutput.AppendText(commandText);
            }

            if (data.Equals("clear"))
            {
                txtOutput.Clear();
            }

        }

    }
}
