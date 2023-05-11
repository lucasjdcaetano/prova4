
using System.Diagnostics;
public class FormsAcesso: Form
{
    private Label lblLogin;
    private Label lblPass;
    private TextBox txtLogin;
    private TextBox txtPass;
    private Button botaoOla;
    private Button botaoFechar;
 

    public FormsAcesso()
    {
        // Configura a janela do programa
        Text = "PROVA 4";
        Size = new System.Drawing.Size(300, 250);
        BackColor = ColorTranslator.FromHtml("#6495ED");

        // Cria uma label para login
        lblLogin = new Label();
        lblLogin.Text = "Nome:";
        lblLogin.Location = new System.Drawing.Point(120, 40);
        lblLogin.AutoSize = true;
        Controls.Add(lblLogin);

        // Cria uma caixa de texto
        txtLogin = new TextBox();
        txtLogin.Location = new System.Drawing.Point(50, 70);
        txtLogin.Size = new System.Drawing.Size(200, 20);
        Controls.Add(txtLogin);

        // Cria um botão de enviar
        botaoOla = new Button();

        botaoOla.Text = "Olá";
        botaoOla.Location = new System.Drawing.Point(100, 120);
        botaoOla.Click += new EventHandler(botaoOla_Click);
        Controls.Add(botaoOla);

        botaoFechar = new Button();

        botaoFechar.Text = "Fechar";
        botaoFechar.Location = new System.Drawing.Point(100, 170);
        botaoFechar.Click += new EventHandler(botaoFechar_Click);
        Controls.Add(botaoFechar);

    }

    private void botaoFechar_Click(object sender, EventArgs e)
        {
            Close();    
        }  

    // Evento que é chamado quando o botão de enviar é clicado
    private void botaoOla_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Olá {txtLogin.Text}");
    }

    static void Main()
    {
        Application.Run(new FormsAcesso());


    }
}