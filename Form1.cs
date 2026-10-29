namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text.Trim();

            if (string.IsNullOrWhiteSpace(tarea))
            {
                MessageBox.Show("Escribe una tarea antes de agregarla.");
                txtTarea.Focus();
                return;
            }

            lstTareas.Items.Add(tarea);

            txtTarea.Clear();
            txtTarea.Focus();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una tarea para eliminarla.");
                return;
            }

            lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
