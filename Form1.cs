namespace JuegoDe4Líneas
{
    public partial class Form1 : Form
    {
        // Variables públicas para los nombres de los jugadores
        public static string Jugador1;
        public static string Jugador2;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Guardar los nombres de los jugadores
            Jugador1 = txtJugador1.Text;
            Jugador2 = txtJugador2.Text;

            // Validar que ambos nombres estén ingresados
            if (string.IsNullOrEmpty(Jugador1) || string.IsNullOrEmpty(Jugador2))
            {
                MessageBox.Show("Por favor, ingresa ambos nombres.");
                return;
            }

            // Abrir el formulario del juego
            FormJuego juego = new FormJuego();
            juego.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txtJugador1.Clear();
            txtJugador2.Clear();
        }
    }
}
