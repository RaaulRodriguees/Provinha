namespace ProvaRaulMartinsRodrigues
{
    public partial class Form1 : Form
    {
        public object Int { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Bot�o para fechar a aplica��o
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Bot�o para limpar as TextBox e Labels
        private void button1_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "";
            txtBx2.Text = "";
            txtBx3.Text = "";
            txtBx4.Text = "";
            lbVencedor.Text = "";
            lbPerdedor.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Esse if analisar� se h� alguma TextBox em branco, caso tenha aparecer� uma MessageBox se n�o ele continua
            if (txtBx1.Text.Length == 0 || txtBx2.Text.Length == 0 || txtBx3.Text.Length == 0 || txtBx4.Text.Length == 0)
            {

                MessageBox.Show("Insira valores nas casas em branco");
            }
            else
            {

                //Converte os n�meros da TextBox que est�o em String para int
                int num1 = int.Parse(txtBx1.Text);
                int num2 = int.Parse(txtBx2.Text);
                int num3 = int.Parse(txtBx3.Text);
                int num4 = int.Parse(txtBx4.Text);

                //Esse if analisar� se os n�meros (agora convertidos para int) s�o negativos, se forem ir� aparecer uma MessageBox, se n�o continuar�
                if (num1 < 0 || num2 < 0 || num3 < 0 || num4 < 0)
                {
                    MessageBox.Show("Insira apenas n�meros positvos");
                }
                else
                {

                    //Algumas variaveis de auxilio
                    int vitoria = 3;
                    int empate = 1;
                    int SantosPontos = 0;
                    int PalmeirasPontos = 0;
                    int jogo1S = 0;
                    int jogo2S = 0;
                    int jogo1P = 0;
                    int jogo2P = 0;

                    //Caso a TextBox1 (Santos) for maior que TextBox2 (Palmeiras), Santos recebe a v�riavel vit�ria (3 pontos)
                    if (num1 > num2)
                    {
                        jogo1S = vitoria;

                    }

                    //Caso a TextBox4 (Santos) for maior que TextBox3 (Palmeiras), Santos recebe a v�riavel vit�ria (3 pontos)
                    if (num4 > num3)
                    {
                        jogo2S = vitoria;

                    }

                    //Caso a TextBox2 (Palmeiras) for maior que TextBox1 (Santos), Palmeiras recebe a v�riavel vit�ria (3 pontos)
                    if (num2 > num1)
                    {
                        jogo1P = vitoria;

                    }

                    //Caso a TextBox3 (Palmeiras) for maior que TextBox4 (Santos), Palmeiras recebe a v�riavel vit�ria (3 pontos)
                    if (num3 > num4)
                    {
                        jogo2P = vitoria;

                    }

                    //Caso a TextBox1 seja igual a TextBox2, ambos os times ir�o receber a v�riavel empate (1 ponto)
                    if (num1 == num2)
                    {
                        jogo1S = empate;
                        jogo1P = empate;
                    }

                    //Caso a TextBox3 seja igual a TextBox4, ambos os times ir�o receber a v�riavel empate (1 ponto)
                    if (num3 == num4)
                    {
                        jogo2S = empate;
                        jogo2P = empate;
                    }

                    //Aqui os pontos ser�o somados nas v�riaveis SantosPontos e PalmeirasPontos
                    SantosPontos = jogo1S + jogo2S;
                    PalmeirasPontos = jogo1P + jogo2P;

                    //Aqui vamos converter esses valores de int para String
                    String PontosSantos = Convert.ToString(SantosPontos);
                    String PontosPalmeiras = Convert.ToString(PalmeirasPontos);

                    //Se Santos tiver mais pontos que o Palmeiras, Santos � campe�o
                    if (SantosPontos > PalmeirasPontos)
                    {
                        lbVencedor.Text = "Santos";
                        lbPerdedor.Text = "Palmeiras";

                        //Se for campe�o por 6 pontos (2 vit�rias), aparecer� essa MessageBox
                        if(SantosPontos == 6)
                        {
                            MessageBox.Show("O Santos � Campe�o", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Se for camp�o por 4 pontos (1 vit�ria e 1 empate), aparecer� essa MessageBox
                        }else if(SantosPontos == 4)
                        {
                            MessageBox.Show("O Santos � Campe�o", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }

                    //Se Palmeiras tiver mais pontos que o Santos, Palmeiras � campe�o
                    if (PalmeirasPontos > SantosPontos)
                    {
                        lbVencedor.Text = "Palmeiras";
                        lbPerdedor.Text = "Santos";

                        //Se for campe�o por 6 pontos (2 vit�rias), aparecer� essa MessageBox
                        if (PalmeirasPontos == 6)
                        {
                            MessageBox.Show("O Palmeiras � Campe�o", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //Se for camp�o por 4 pontos (1 vit�ria e 1 empate), aparecer� essa MessageBox
                        else if (PalmeirasPontos == 4)
                        {
                            MessageBox.Show("O Palmeiras � Campe�o", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    //Aqui aparecer� uma MessageBox de empate caso ambos tenham a mesma quantidade de pontos
                    else if (PalmeirasPontos == SantosPontos)
                    {
                        lbVencedor.Text = "Ninguem";
                        lbPerdedor.Text = "Ninguem";
                        MessageBox.Show("O t�tulo ser� disputado nos p�naltis", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
  
                }

            }
        }
    }
}