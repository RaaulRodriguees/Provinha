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
        //Botão para fechar a aplicação
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Botão para limpar as TextBox e Labels
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
            //Esse if analisará se há alguma TextBox em branco, caso tenha aparecerá uma MessageBox se não ele continua
            if (txtBx1.Text.Length == 0 || txtBx2.Text.Length == 0 || txtBx3.Text.Length == 0 || txtBx4.Text.Length == 0)
            {

                MessageBox.Show("Insira valores nas casas em branco");
            }
            else
            {

                //Converte os números da TextBox que estão em String para int
                int num1 = int.Parse(txtBx1.Text);
                int num2 = int.Parse(txtBx2.Text);
                int num3 = int.Parse(txtBx3.Text);
                int num4 = int.Parse(txtBx4.Text);

                //Esse if analisará se os números (agora convertidos para int) são negativos, se forem irá aparecer uma MessageBox, se não continuará
                if (num1 < 0 || num2 < 0 || num3 < 0 || num4 < 0)
                {
                    MessageBox.Show("Insira apenas números positvos");
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

                    //Caso a TextBox1 (Santos) for maior que TextBox2 (Palmeiras), Santos recebe a váriavel vitória (3 pontos)
                    if (num1 > num2)
                    {
                        jogo1S = vitoria;

                    }

                    //Caso a TextBox4 (Santos) for maior que TextBox3 (Palmeiras), Santos recebe a váriavel vitória (3 pontos)
                    if (num4 > num3)
                    {
                        jogo2S = vitoria;

                    }

                    //Caso a TextBox2 (Palmeiras) for maior que TextBox1 (Santos), Palmeiras recebe a váriavel vitória (3 pontos)
                    if (num2 > num1)
                    {
                        jogo1P = vitoria;

                    }

                    //Caso a TextBox3 (Palmeiras) for maior que TextBox4 (Santos), Palmeiras recebe a váriavel vitória (3 pontos)
                    if (num3 > num4)
                    {
                        jogo2P = vitoria;

                    }

                    //Caso a TextBox1 seja igual a TextBox2, ambos os times irão receber a váriavel empate (1 ponto)
                    if (num1 == num2)
                    {
                        jogo1S = empate;
                        jogo1P = empate;
                    }

                    //Caso a TextBox3 seja igual a TextBox4, ambos os times irão receber a váriavel empate (1 ponto)
                    if (num3 == num4)
                    {
                        jogo2S = empate;
                        jogo2P = empate;
                    }

                    //Aqui os pontos serão somados nas váriaveis SantosPontos e PalmeirasPontos
                    SantosPontos = jogo1S + jogo2S;
                    PalmeirasPontos = jogo1P + jogo2P;

                    //Aqui vamos converter esses valores de int para String
                    String PontosSantos = Convert.ToString(SantosPontos);
                    String PontosPalmeiras = Convert.ToString(PalmeirasPontos);

                    //Se Santos tiver mais pontos que o Palmeiras, Santos é campeão
                    if (SantosPontos > PalmeirasPontos)
                    {
                        lbVencedor.Text = "Santos";
                        lbPerdedor.Text = "Palmeiras";

                        //Se for campeão por 6 pontos (2 vitórias), aparecerá essa MessageBox
                        if(SantosPontos == 6)
                        {
                            MessageBox.Show("O Santos é Campeão", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Se for campão por 4 pontos (1 vitória e 1 empate), aparecerá essa MessageBox
                        }else if(SantosPontos == 4)
                        {
                            MessageBox.Show("O Santos é Campeão", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }

                    //Se Palmeiras tiver mais pontos que o Santos, Palmeiras é campeão
                    if (PalmeirasPontos > SantosPontos)
                    {
                        lbVencedor.Text = "Palmeiras";
                        lbPerdedor.Text = "Santos";

                        //Se for campeão por 6 pontos (2 vitórias), aparecerá essa MessageBox
                        if (PalmeirasPontos == 6)
                        {
                            MessageBox.Show("O Palmeiras é Campeão", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //Se for campão por 4 pontos (1 vitória e 1 empate), aparecerá essa MessageBox
                        else if (PalmeirasPontos == 4)
                        {
                            MessageBox.Show("O Palmeiras é Campeão", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    //Aqui aparecerá uma MessageBox de empate caso ambos tenham a mesma quantidade de pontos
                    else if (PalmeirasPontos == SantosPontos)
                    {
                        lbVencedor.Text = "Ninguem";
                        lbPerdedor.Text = "Ninguem";
                        MessageBox.Show("O título será disputado nos pênaltis", "Prova 1 Bimestre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
  
                }

            }
        }
    }
}