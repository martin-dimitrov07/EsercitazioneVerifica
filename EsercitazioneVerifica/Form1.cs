using System.Diagnostics.Eventing.Reader;

namespace EsercitazioneVerifica
{
    public partial class Form1 : Form
    {
        List<Contatto> contatti = new List<Contatto>(); //come vettore a dimensione variabile

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Contatto c = Contatto.CreaContatto(txtNome.Text, txtTelefono.Text);

            if (c == null)
            {
                MessageBox.Show("Compilare tutti e due i campi richiesti");
            }
            else if (contieneLst(c))
            {
                MessageBox.Show("Non è possibile inserire contatti esistenti");
            }
            else
            {
                contatti.Add(c);
                mostraListBox();
            }

            txtNome.Text = "";
            txtTelefono.Text = "";
        }

        private bool contieneLst(Contatto c)
        {
            foreach (var contatto in contatti)
            {
                if (contatto.telefono == c.telefono)
                    return true;
            }

            return false;
        }

        private void mostraListBox()
        {
            lstContatti.Items.Clear();

            foreach (var contatto in contatti)
            {
                string s = contatto.nome + " - " + contatto.telefono;
                lstContatti.Items.Add(s);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lstContatti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona un contatto della listbox");
            }
            else
            {
                string nome = lstContatti.SelectedItem.ToString().Split('-')[0].Trim();
                string telefono = lstContatti.SelectedItem.ToString().Split('-')[1].Trim();

                Contatto.EliminaContatto(contatti, nome, telefono);

                mostraListBox();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstContatti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona un contatto della listbox");
            }
            else
            {
                string telefono = lstContatti.SelectedItem.ToString().Split('-')[1].Trim();

                foreach (Contatto contatto in contatti)
                {
                    if (contatto.telefono == telefono)
                        Contatto.ModificaContatto(contatto, txtNome.Text, txtTelefono.Text);
                }

                mostraListBox();
            }

            txtNome.Text = "";
            txtTelefono.Text = "";
        }
    }
}
