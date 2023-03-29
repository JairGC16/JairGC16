using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class semaforo : Form
    {
        int i = 0;   //Variable que utilizaremos para el uso del Switch Case.
        public semaforo()
        {
            InitializeComponent();
        }
         
        private void Iniciar_Click(object sender, EventArgs e)
        {   //En el evento click pondremos las siguientes acciones a realizar.
            timer1.Start();   //Declaramos que el timer se encienda.
            detener.Enabled = true;  //Declaramos que el boton "Detener" este habilitado.
            Apagar.Enabled = true;  //Declaramos que el boton "Apagar" este habilitado.
            Iniciar.Enabled = false;  //Declaramos que el boton "Iniciar" este deshabilitado.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {  //En el picturebox1, pondremos lo siguiente para que se puedan mostrar las imagenes del semaforo.
            pictureBox1.Image = Semaforo.Properties.Resources.semaforo1;  //Buscamos la imagen que se mostrara en el box.
            detener.Enabled = false;  //Declaramos que el boton "detener" este deshabilitado.
            Apagar.Enabled = false;  //Declaramos que el boton "Apagar" este deshabilitado.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           /*Dentro del evento Tick, pondremos un Switch Case, que se encargara de 
                     estar mostrando la secuencia de imagenes que le dara vida a nuestro semaforo. */
            
            switch(i)  //Pondremos la variable que se estara modificando a lo largo de los casos.
            {
                case 0: //Cuando la variable "i" tenga el valor de 0 (Valor predeterminado) se ejecutara lo siguiente.
                    pictureBox1.Image = Semaforo.Properties.Resources.semaforo_verde; //Mostrara la imagen del semaforo en verde.
                    timer1.Interval = 2000;  //Le pondremos un pequeno delay de 2 segundos entre estas imagenes.
                    pictureBox2.Image = Semaforo.Properties.Resources.semaforo_rojo;  //Mostrara la imagen del semaforo en rojo.
                    timer1.Interval = 3500;  //Delay de 3,5 segundos.
                    i = 1;  //Esta es una parte importante del case, aqui se le sumara 1 a la variable, para que pase al siguiente caso.
                    break;  //Fin del caso 0.

                case 1:  //Cuando la variable "i" tenga el valor de 1, se ejecutara lo siguiente.
                    pictureBox1.Image = Semaforo.Properties.Resources.semaforo_amarillo;  //Mostrara la imagen del semaforo en amarillo.
                    timer1.Interval = 1500;  //Delay de 1,5 segundos.                   
                    i = 2;  //A la variable se le cambia el valor de 1 a 2.
                    break;  //Fin del caso 1.

                case 2:  //Cuando la variable "i" tenga el valor de 2, se ejecutara lo siguiente.
                    pictureBox1.Image = Semaforo.Properties.Resources.semaforo_rojo;  //Mostrara la imagen del semaforo en rojo.
                    timer1.Interval = 3500;  //Delay de 3,5 segundos.
                    pictureBox2.Image = Semaforo.Properties.Resources.semaforo_verde;  //Mostrara la imagen del semaforo en verde.
                    timer1.Interval = 2000;  //Delay de 2 segundos.
                    i = 3;  //A la variable se le cambia el valor de 2 a 3.
                    break;  //Fin del caso 2.
                    
                case 3:  //Cuando la variable "i" tenga el valor de 3, se ejecutara lo siguiente.
                    pictureBox2.Image = Semaforo.Properties.Resources.semaforo_amarillo;  //Mostrara la imagen del semaforo en amarillo.
                    timer1.Interval = 1500;  //Delay de 1,5 segundos.
                    i = 0;  //A la variable se le cabia el valor de 3 a 0 para volver a comenzar la secuencia de imagenes, a esto se le llama loop.
                    break;  //Fin del caso 3.
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {  //En el picturebox2, pondremos lo siguiente para que se puedan mostrar las imagenes del semaforo.
            pictureBox2.Image = Semaforo.Properties.Resources.semaforo1;  //Buscamos la imagen para mostrar en el box.
            detener.Enabled = false;  //Declaramos que el boton "detener" este deshabilitado.
            Apagar.Enabled = false;  //Declaramos que el boton "Apagar" este deshabilitado.
        }

        private void detener_Click(object sender, EventArgs e)
        {  //Dentro del evento click del boton "detener", haremos que al pulsarlo, cambie de texto para ahorrarnos un boton y hacerlo 2 en 1.
            //Con la funcion "if - else" vamos a realizar el cambio de texto del boton en cuestion.
            if(detener.Text=="Detener")  //Aqui dice, que si el boton este en el estado de "Detener"-->
            { //--> Se cumplira la condicion y por lo tanto, el timer se pausa y el texto del boton cambia de "Detener" a "Seguir".
            timer1.Enabled = false;
            detener.Text = "Seguir";
            }
            else  //Con la funcion "else" diremos lo contrario a lo anterior.
                if (detener.Text == "Seguir")  ////Aqui dice, que si el boton este en el estado de "Seguir"-->
                {//--> Se cumplira la condicion y por lo tanto, el timer sigue y el texto del boton cambia de "Seguir" a "Detener".
                    timer1.Enabled = true;
                    detener.Text = "Detener";
                }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {  //Dentro del evento click del boton "Apagar" declaramos lo siguiente.
            timer1.Stop();  //El timer se apaga por completo.
            detener.Enabled = false;  //Declaramos que el boton "detener" sea deshabilitado.
            Apagar.Enabled = false;  //Declaramos que el boton "Apagar" sea deshabilitado.
            Iniciar.Enabled = true;  //Declaramos que el boton "Iniciar" sea habilitado.
            pictureBox1.Image = Semaforo.Properties.Resources.semaforo1;  //Y nos regresamos a la imagen donde ninguna luz del semaforo esten encencidas.
            pictureBox2.Image = Semaforo.Properties.Resources.semaforo1;  // ?
        }//FIN DEL CODIGO.
    }                  // 6B Mecatronica, Equipo: Los Aprencides de Fibonacci, a 26/04/2017.

}                     //Gracias por tomarse el tiempo de leerlo profesor, que tenga buen dia!
