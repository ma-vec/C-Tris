namespace _01_tps_button_sender
{
    public partial class Form1 : Form
    {
        private string turno;     //Gestisce carattere da stampare X/O
        private int celleLibere = 9; //Numero di celle non cliccate
        private bool end = false;
        private bool parita = true;
        private string win;
        private Random generatore = new Random();

        // Variabile di classe per il tempo rimanente
        private int tempo_rimanente;
        private int countdownTime = 5; // Imposta la durata del conto alla rovescia in secondi

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTurno()
        {
            if (turno == "X")
            {
                turno = "O";
            }
            else
            {
                turno = "X";
            }
            label_turno.Text = turno;
            celleLibere--;
            //Reset timer
            timer.Stop();
            oneSec_timer.Stop();
            tempo_rimanente = countdownTime;
            label_timer.Text = tempo_rimanente.ToString();
            timer.Start();
            oneSec_timer.Start();
        }

        private void CheckEnd()
        {
            // Controllo righe, colonne e diagonali
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||
                (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
            {
                end = true;
                parita = false;
            } else if (celleLibere == 0)
            {
                end = true;
                parita = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button pulsante = (Button)sender;   //Per ottenere ID button premuto
            if (pulsante.Text == "")
            {          //Evita sovrascrizioni
                pulsante.Text = turno;
                UpdateTurno();

                CheckEnd();

                
                if (end)
                {
                    timer.Stop();
                    oneSec_timer.Stop();
                    if (!parita)
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
                    Form1_Load(this, e);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)     //Stabilisce giocatore che inizia e reset game
        {
            end = false;
            parita = true;
            celleLibere = 9;
            label_fissa_turno.Text = "E' il turno di ";
            label_fissa_timer.Text = "Scade tra ";
            if (generatore.Next(2) == 0)
            {
                turno = "X";
            }
            else
            {
                turno = "O";
            }

            label_turno.Text = turno;

            // Resetta tutti i pulsanti
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = "";
            }

            // Inizializza il timer e il tempo rimanente
            timer.Interval = countdownTime * 1000;
            tempo_rimanente = countdownTime;
            label_timer.Text = tempo_rimanente.ToString(); // Mostra il tempo iniziale
            timer.Start();
            oneSec_timer.Start(); // Avvia il timer
        }

        private void timer_Tick(object sender, EventArgs e)
        {
    if (end == false)
    {
        int numeroCasuale;

        // Genera un numero casuale fino a trovare un pulsante vuoto
        do
        {
            numeroCasuale = generatore.Next(9);
        }
        while (!PulsanteLibero(numeroCasuale) && end == false);

        // Assegna il simbolo al pulsante vuoto trovato
        switch (numeroCasuale)
        {
            case 0: button1.Text = turno; break;
            case 1: button2.Text = turno; break;
            case 2: button3.Text = turno; break;
            case 3: button4.Text = turno; break;
            case 4: button5.Text = turno; break;
            case 5: button6.Text = turno; break;
            case 6: button7.Text = turno; break;
            case 7: button8.Text = turno; break;
            case 8: button9.Text = turno; break;
        }

                // Controlla immediatamente se qualcuno ha vinto o se c'è un pareggio
                UpdateTurno();
                CheckEnd();

                if (end)
                {
                    // Se il gioco è finito, ferma i timer e mostra il messaggio
                    timer.Stop();
                    oneSec_timer.Stop();

                    if (!parita)
                    {
                        // Se non è una parità, dichiara il vincitore
                        
                        if(turno=="O") { win = "Vince X"; } else { win = "Vince O"; } //opposto per garantire parità, update eseguito prima
                    }
                    else
                    {
                        // In caso di parità
                        label_fissa_turno.Text = "FINE!";
                        label_turno.Text = "";
                        win = "Parita'";
                    }

                    // Mostra il risultato e riavvia il gioco
                    MessageBox.Show(win);
                    Form1_Load(this, e); // Ricomincia il gioco
                }
                
    }
}


        private void oneSec_timer_Tick(object sender, EventArgs e)
        {
            
            // Decrementa il tempo rimanente
            tempo_rimanente--;
            // Aggiorna l'etichetta con il tempo rimanente
            label_timer.Text = tempo_rimanente.ToString();

            // Se il tempo rimanente arriva a zero, ferma il timer
            if (tempo_rimanente <= 0)
            {
                tempo_rimanente = countdownTime;
            }
        }

        // Funzione che verifica se il pulsante corrispondente al numero casuale è vuoto
        private bool PulsanteLibero(int indice)
        {
            switch (indice)
            {
                case 0: return string.IsNullOrEmpty(button1.Text);
                case 1: return string.IsNullOrEmpty(button2.Text);
                case 2: return string.IsNullOrEmpty(button3.Text);
                case 3: return string.IsNullOrEmpty(button4.Text);
                case 4: return string.IsNullOrEmpty(button5.Text);
                case 5: return string.IsNullOrEmpty(button6.Text);
                case 6: return string.IsNullOrEmpty(button7.Text);
                case 7: return string.IsNullOrEmpty(button8.Text);
                case 8: return string.IsNullOrEmpty(button9.Text);
                default: return false;
            }
        }

    }
}
