using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFicheros
{
    public partial class Form1 : Form
    {
        Fichero _f1;
        List<string> _l1;
        List<Tipo> _l2;
        List<string> _cajas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Añade desde el listbox a los combobox
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                cBJ2.Items.Add(listBox1.Items[i]);
                cBJugador.Items.Add(listBox1.Items[i]);
            }

            _l1 = new List<string>();
            _l2 = new List<Tipo>();
            _cajas = new List<string>();
            _l1.Add("partido");
            _l1.Add("jugador1");
            _l1.Add("jugador2");
            _l1.Add("sets1");
            _l1.Add("sets2");

            _l2.Add(Tipo.Entero);
            _l2.Add(Tipo.Cadena);
            _l2.Add(Tipo.Cadena);
            _l2.Add(Tipo.Entero);
            _l2.Add(Tipo.Entero);
            try
            {
                _f1 = new Fichero("partidosATP.txt", _l1, _l2);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }
        }

//--------------------------------PÁGINA 1------------------------------------------//
        /// <summary>
        /// Añade desde la lista de jugadores al jugador 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            tBJ1.Text = listBox1.SelectedItem.ToString();
        }

        /// <summary>
        /// Carga sobre el fichero los datos introducidos en el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGraba_Click(object sender, EventArgs e)
        {
            try
            {
                if (_f1.Abre())
                {
                    _f1.Fin();
                    Cargar(_cajas);
                    _f1.Escribe(_cajas);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                _f1.Cierra();
            }
        }

        /// <summary>
        /// Carga sobre la lista cajas/_cajas los resultados del partido, haciendo el cálculo de los sets ganados.
        /// </summary>
        /// <param name="cajas"></param>
        private void Cargar(List<string> cajas)
        {
            cajas.Add(nUDPartido.Text);
            cajas.Add(tBJ1.Text);
            cajas.Add(cBJ2.Text);

            int j1S1 = Convert.ToInt32(nUPJ1s1.Text);
            int j1S2 = Convert.ToInt32(nUPJ1s2.Text);
            int j1S3 = Convert.ToInt32(nUPJ1s3.Text);
            int j2S1 = Convert.ToInt32(nUPJ2s1.Text);
            int j2S2 = Convert.ToInt32(nUPJ2s2.Text);
            int j2S3 = Convert.ToInt32(nUPJ2s3.Text);
            int cont1, cont2;
            cont1 = cont2 = 0;

            if (j1S1 > j2S1)
                cont1++;
            else
                cont2++;
            if (j1S2 > j2S2)
                cont1++;
            else
                cont2++;
            if (j1S3 > j2S3)
                cont1++;
            else
                cont2++;

            cajas.Add(cont1.ToString());
            cajas.Add(cont2.ToString());
        }

        /// <summary>
        /// Carga sobre el DGV los datos que tiene el fichero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLee_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> caja;
            caja = new List<string>();
            try
            {
                _f1.Abre();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            dataGridView1.Rows.Clear();
            for (i = 0; i < _f1.NumRegistros; i++)
            {
                caja.Clear();
                try
                {
                    caja = _f1.Lee();
                    dataGridView1.Rows.Add(caja[0], caja[1], caja[2], caja[3], caja[4]);
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            try
            {
                _f1.Cierra();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
//--------------------------------FIN PÁGINA 1------------------------------------------//

//---------------------------------------PÁGINA 2---------------------------------------//

        private string CuentaGanadas(string name)
        {
            int i;
            int cont = 0;
            List<string> devol = new List<string>();

            try
            {
                _f1.Abre();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            for (i = 0; i < _f1.NumRegistros; i++)
            {
                devol.Clear();
                try
                {
                    devol = _f1.Lee();
                    //Si encuentra coincidencia en jugador 1 y jugador 1 ganó, sumar.
                    if (devol[1].Equals(name) && (Convert.ToInt32(devol[3]) > Convert.ToInt32(devol[4])))
                        cont++;
                    //Si encuentra coincidencia en jugador 2 y jugador 2 ganó, sumar.
                    if (devol[2].Equals(name) && (Convert.ToInt32(devol[4]) > Convert.ToInt32(devol[3])))
                        cont++;
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            try
            {
                _f1.Cierra();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            return (cont.ToString());
        }

        /// <summary>
        /// Carga sobre el DGV los resultados finales del jugador que hhemos seleccionado en el combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(cBJugador.SelectedItem, CuentaGanadas(cBJugador.SelectedItem.ToString()));
        }

        /// <summary>
        /// Ordena el DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOrdena_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);
        }

        //--------------------------------FIN PÁGINA 2------------------------------------------//

        //---------------------------------------VALIDACIONES-----------------------------------//

        /// <summary>
        /// Controla que el jugador no juegue contra si mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBJ2_Validating(object sender, CancelEventArgs e)
        {
            ComboBox auxBox = (ComboBox)sender;

            if (auxBox.Text.Equals(tBJ1.Text))
            {
                MessageBox.Show("Un jugador no puede jugar contra si mismo.");
                auxBox.SelectAll();
                auxBox.Focus();
            }
        }

        /// <summary>
        /// Controla que el número de partido no exista ya en el fichero guardado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nUDPartido_Validating(object sender, CancelEventArgs e)
        {
            int i;
            int cont = 0;
            List<string> devol = new List<string>();
            NumericUpDown auxBox = (NumericUpDown)sender;

            try
            {
                _f1.Abre();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            for (i = 0; i < _f1.NumRegistros; i++)
            {
                devol.Clear();
                try
                {
                    devol = _f1.Lee();
                    if (devol[0].Equals(auxBox.Text))
                    {
                        MessageBox.Show("Ya existe un partido con esa ID.");
                        auxBox.Focus();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            try
            {
                _f1.Cierra();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }
    }
}
