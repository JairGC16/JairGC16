namespace Semaforo
{
    public partial class Form1 : Form
    {
        int caso1 = 0;
        int caso2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilitamos el boton apagar
            btnApagar.Enabled = false;
            //Deshabilitamos el boton detenerbtnEncender.Enabled
            btnDetener.Enabled = false;

            // Semáforo 1
            ptbImagen1.Image = Semaforo.Properties.Resources.Apagado;
            label1.Text = "Semáforo 1 apagado";

            // Semáforo 2
            ptbImagen2.Image = Semaforo.Properties.Resources.Apagado;
            label2.Text = "Semáforo 2 apagado";
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            //Iniciando el timer, el cual va a controlar el tiempo de encendido
            // Del semáforo 1
            timer1.Start();
            //Deshabilitar el botón encender (en este momento no se necesita
            //habilitado)
            btnEncender.Enabled = false;
            //Habilitamos el botón detener
            btnDetener.Enabled = true;
            //Habilitamos el botón apagar
            btnApagar.Enabled = true;
            //Determinamos el estado del semáforo 1
            label1.Text = "Semáforo 1 encendido";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso1)
            {
                case 0:
                    //Se enciende la luz verde del semáforo 1 y la luz roja del semáforo 2
                    ptbImagen1.Image = Semaforo.Properties.Resources.Verde;
                    ptbImagen2.Image = Semaforo.Properties.Resources.Rojo;
                    //Determinando intervalo de tiempo para semáforo 1
                    timer1.Interval = 5000;
                    //El caso va a iniciar primero con la luz verde del semáforo 1 y la luz roja del semáforo 2
                    caso1 = 1;
                    break;
                case 1:
                    //Se enciende la luz amarilla del semáforo 1 y la luz roja del semáforo 2
                    ptbImagen1.Image = Semaforo.Properties.Resources.Amarillo;
                    ptbImagen2.Image = Semaforo.Properties.Resources.Rojo;
                    //Determinando intervalo de tiempo para semáforo 1
                    timer1.Interval = 2000;
                    //El caso va a continuar con la luz amarilla del semáforo 1 y la luz roja del semáforo 2
                    caso1 = 2;
                    break;
                case 2:
                    //Se enciende la luz roja del semáforo 1 y la luz verde del semáforo 2
                    ptbImagen1.Image = Semaforo.Properties.Resources.Rojo;
                    ptbImagen2.Image = Semaforo.Properties.Resources.Verde;
                    //Determinando intervalo de tiempo para semáforo 2
                    timer2.Interval = 5000;
                    //El caso va a iniciar primero con la luz roja del semáforo 1 y la luz verde del semáforo 2
                    caso2 = 1;
                    break;
                default:
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (caso2)
            {
                case 0:
                    break;
                case 1:
                    //Se enciende la luz amarilla del semáforo 2 y la luz roja del semáforo 1
                    ptbImagen2.Image = Semaforo.Properties.Resources.Amarillo;
                    ptbImagen1.Image = Semaforo.Properties.Resources.Rojo;
