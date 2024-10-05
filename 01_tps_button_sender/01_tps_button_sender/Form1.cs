namespace _01_tps_button_sender
{
    public partial class Form1 : Form
    {
        private string turno;     //Gestisce carattere da stampare X/O
        private int celleLibere = 9; //Numero di celle non cliccate
        private bool end = false;
        private string win;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button pulsante = (Button)sender;   //Per ottenere ID button premuto
            if (pulsante.Text == "") {          //Evita sovrascrizioni
                pulsante.Text = turno;
                if (turno == "X") {
                    turno = "O";
                }
                else {
                    turno = "X";
                }
                label_turno.Text = turno;
                celleLibere--;

                if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")//Riga1
                {
                    end = true;

                }
                else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")//Riga2
                {
                    end = true;

                }
                else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")//Riga3
                {
                    end = true;

                }

                else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")//Colonna1
                {
                    end = true;

                }
                else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")//Colonna2
                {
                    end = true;

                }
                else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")//Colonna3
                {
                    end = true;

                }

                else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")//Diag1
                {
                    end = true;

                }
                else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")//Diag1
                {
                    end = true;

                }

                if (celleLibere == 0) {     //Controllo fine gioco
                    end = true;
                }
                if (end == true)
                {
                    if (celleLibere != 0)
                    { //Vincita
                        win = "Vince " + pulsante.Text;
                    }
                    else
                    {
                       label_fissa_turno.Text = "FINE!";
                       label_turno.Text = "";
                       win = "Parita'";
                    }
                    MessageBox.Show(win);
                }

   
            }
        }

        private void Form1_Load(object sender, EventArgs e)     //Stabilisce giocatore che inizia
        {
            Random generatore = new Random();
            if(generatore.Next(2)==0 ) {
                turno = "X";
            } else {
                turno = "O";
            }
            label_turno.Text = turno;
        }
    }
}
