using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFicheros
{
    class Fichero
    {
        string _ficNombre;
        public int NumRegistros;
        FileStream _fs;
        public BinaryReader Br;
        public BinaryWriter Bw;
        List<string> _campos;
        List<Tipo> _tipos;
        public Registro Reg;
        public List<string> Devol;

        public Fichero(string fnom, List<string> lista1, List<Tipo> lista2)
        {
            _ficNombre = fnom;
            NumRegistros = 0;
            _fs = null;
            Br = null;
            Bw = null;
            if (!File.Exists(_ficNombre))
            {
                try
                {
                    _fs = new FileStream(_ficNombre, FileMode.Create, FileAccess.Write);
                    _fs.Close();
                }
                catch (Exception e1)
                {
                    throw new Exception(e1.Message);
                }
            }

            _campos = new List<string>();
            _tipos = new List<Tipo>();
            _campos.InsertRange(0, lista1);
            _tipos.InsertRange(0, lista2);



            try
            {
                Reg = new Registro(lista1, lista2);
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message);
            }
            NumRegistros = CalculaRegistros();
        }

        int CalculaRegistros()
        {
            int cuenta = 0;
            bool fin = false;
            if (Abre())
            {
                do
                {
                    try
                    {
                        Reg.Lee(Br);
                        cuenta++;
                    }
                    catch (Exception)
                    {
                        fin = true;
                    }
                } while (fin == false);
                Cierra();
            }
            return (cuenta);
        }

        public void Escribe(List<string> listavalores)
        {
            try
            {
                Reg.Escribe(listavalores, Bw);
                NumRegistros++;
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message);
            }
        }

        public List<string> Lee()
        {
            try
            {
                Devol = Reg.Lee(Br);
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message);
            }
            return (Devol);
        }

        public void Trunca()
        {
            _fs = new FileStream(_ficNombre, FileMode.Truncate);
            _fs.Close();
            NumRegistros = 0;
        }

        public bool Abre()
        {
            try
            {
                _fs = new FileStream(_ficNombre, FileMode.Open, FileAccess.ReadWrite);
            }
            catch (Exception e1)
            {
                Cierra();
                throw new Exception(e1.Message + "\n" + e1.Source);
            }
            try
            {
                Br = new BinaryReader(_fs);
            }
            catch (Exception e1)
            {
                Cierra();
                throw new Exception(e1.Message + "\n" + e1.Source);
            }
            try
            {
                Bw = new BinaryWriter(_fs);
            }
            catch (Exception e1)
            {
                Cierra();
                throw new Exception(e1.Message + "\n" + e1.Source);
            }
            return (true);
        }

        public void Cierra()
        {
            if (Br != null)
                Br.Close();
            if (Bw != null)
                Bw.Close();
            if (_fs != null)
                _fs.Close();
            Br = null;
            Bw = null;
            _fs = null;
        }

        public void Inicio()
        {
            _fs.Seek(0, SeekOrigin.Begin);
        }

        public void Fin()
        {
            _fs.Seek(0, SeekOrigin.End);
        }

    }
}

