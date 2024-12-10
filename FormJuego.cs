using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDe4Líneas
{
    public partial class FormJuego : Form
    {
        // Variables para el tablero y el turno
        private Button[,] botones;
        private string turno;

        public FormJuego()
        {
            InitializeComponent();
            InicializarTablero();
            turno = "X"; // Empieza el Jugador 1
            lblTurno.Text = $"Turno de {Form1.Jugador1}";
        }

        private void InicializarTablero()
        {
            // Crear una matriz de botones para el tablero 8x8
            botones = new Button[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button
                    {
                        Name = $"btn_{i}_{j}",
                        Text = "",
                        Width = 50,
                        Height = 50
                    };

                    btn.Click += BotonClick; // Asignar evento de clic
                    botones[i, j] = btn;
                    tableLayoutPanel1.Controls.Add(btn, j, i); // Agregar al TableLayoutPanel
                }
            }
        }

        private void BotonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && string.IsNullOrEmpty(btn.Text))
            {
                btn.Text = turno;

                // Verificar si hay un ganador
                if (VerificarGanador())
                {
                    MessageBox.Show($"¡{(turno == "X" ? Form1.Jugador1 : Form1.Jugador2)} !Felicidades has ganado!");
                    ReiniciarJuego();
                    return;
                }

                // Cambiar el turno
                turno = turno == "X" ? "O" : "X";
                lblTurno.Text = $"Turno de {(turno == "X" ? Form1.Jugador1 : Form1.Jugador2)}";
            }
        }

        private bool VerificarGanador()
        {
            // Verificar filas, columnas y diagonales
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!string.IsNullOrEmpty(botones[i, j].Text) &&
                        (VerificarDireccion(i, j, 1, 0) || // Horizontal
                         VerificarDireccion(i, j, 0, 1) || // Vertical
                         VerificarDireccion(i, j, 1, 1) || // Diagonal principal
                         VerificarDireccion(i, j, 1, -1))) // Diagonal secundaria
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool VerificarDireccion(int x, int y, int dx, int dy)
        {
            string simbolo = botones[x, y].Text;
            int count = 0;

            for (int k = 0; k < 4; k++)
            {
                int nx = x + k * dx;
                int ny = y + k * dy;

                if (nx >= 0 && ny >= 0 && nx < 8 && ny < 8 && botones[nx, ny].Text == simbolo)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count == 4;
        }

        private void ReiniciarJuego()
        {
            foreach (Button btn in botones)
            {
                btn.Text = ""; // Vaciar cada botón
            }

            turno = "X"; // Reiniciar el turno
            lblTurno.Text = $"Turno de {Form1.Jugador1}";
        }

        private void lblTurno_Click(object sender, EventArgs e)
        {

        }

        private void FormJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
