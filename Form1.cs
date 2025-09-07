using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        TextBox display = null!; // garante inicialização
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
            CriarInterface();
        }

       private void CriarInterface()
{
    this.Text = "Calculadora Simples";
    this.Size = new System.Drawing.Size(300, 400);

    display = new TextBox();
    display.ReadOnly = true;
    display.TextAlign = HorizontalAlignment.Right;
    display.Dock = DockStyle.Top;
    display.Height = 50;
    this.Controls.Add(display);

    string[] botoes = { "7","8","9","+",
                        "4","5","6","-",
                        "1","2","3","*",
                        "0","C","=","/" };

    var painel = new TableLayoutPanel();
    painel.RowCount = 4;
    painel.ColumnCount = 4;
    painel.Dock = DockStyle.Fill;

    // Distribui colunas e linhas igualmente
    for (int i = 0; i < 4; i++)
    {
        painel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        painel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
    }

    foreach (string texto in botoes)
    {
        var btn = new Button();
        btn.Text = texto;
        btn.Dock = DockStyle.Fill;
        btn.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
        btn.Click += BtnClick;
        painel.Controls.Add(btn);
    }

    this.Controls.Add(painel);
}


        private void BtnClick(object? sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (char.IsDigit(btn.Text[0]))
            {
                display.Text += btn.Text;
            }
            else if (btn.Text == "C")
            {
                display.Text = "";
                valor1 = valor2 = 0;
                operacao = "";
            }
            else if (btn.Text == "=")
            {
                if (operacao != "")
                {
                    valor2 = double.Parse(display.Text);
                    double resultado = 0;
                    switch (operacao)
                    {
                        case "+": resultado = valor1 + valor2; break;
                        case "-": resultado = valor1 - valor2; break;
                        case "*": resultado = valor1 * valor2; break;
                        case "/": resultado = valor1 / valor2; break;
                    }
                    display.Text = resultado.ToString();
                    operacao = "";
                }
            }
            else
            {
                valor1 = double.Parse(display.Text);
                operacao = btn.Text;
                display.Text = "";
            }
        }
    }
}
