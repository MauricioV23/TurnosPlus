using System;
using System.Windows.Forms;

namespace TurnosPlus
{
    public partial class Form1 : Form
    {
        private ControladorTurno controlador;

        public Form1()
        {
            InitializeComponent();
            controlador = new ControladorTurno();
            // Llama a los métodos para inicializar componentes adicionales
            InicializarControles();
        }

        private void InicializarControles()
        {
            // Crear el botón Solicitar Tiquet
            Button btnSolicitarTiquet = new Button
            {
                Text = "Solicitar Tiquet",
                Location = new System.Drawing.Point(300, 150),
                Size = new System.Drawing.Size(200, 50)
            };
            btnSolicitarTiquet.Click += BtnSolicitarTiquet_Click;

            // Crear el botón para abrir Form2
            Button btnAbrirVista2 = new Button
            {
                Text = "Abrir Vista2",
                Location = new System.Drawing.Point(300, 220),
                Size = new System.Drawing.Size(200, 50)
            };
            btnAbrirVista2.Click += BtnAbrirVista2_Click;

            // Agregar botones al formulario
            Controls.Add(btnSolicitarTiquet);
            Controls.Add(btnAbrirVista2);
        }

        private void BtnSolicitarTiquet_Click(object sender, EventArgs e)
        {
            Turno nuevoTurno = controlador.SolicitarTurno();
            MessageBox.Show("Tiquet solicitado: " + nuevoTurno.Numero, "Tiquet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Aquí puedes implementar la impresión a PDF si lo deseas
        }

        private void BtnAbrirVista2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(controlador);
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica aquí si necesitas al cargar el formulario
        }
    }
}
