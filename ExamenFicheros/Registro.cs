using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFicheros
{

    enum Tipo
    {
        Cadena = 1,
        Entero = 2
    }

    class Registro
    {
        List<string> _campos;
        List<Tipo> _tipos;
        int _numCampos;

        public Registro(List<string> lista1, List<Tipo> lista2)
        {
            int i = 0;
            _campos = new List<string>();
            _tipos = new List<Tipo>();
            _campos.InsertRange(0, lista1);
            _tipos.InsertRange(0, lista2);
            _numCampos = lista1.Count;
        }

        public void Escribe(List<string> listavalores, BinaryWriter bw)
        {
            int entero = 0;

            try
            {
                for (int i = 0; i < listavalores.Count; i++)
                {
                    switch (_tipos[i])
                    {
                        case Tipo.Cadena:
                            bw.Write(listavalores[i].ToString());
                            break;
                        case Tipo.Entero:
                            Int32.TryParse(listavalores[i], out entero);
                            bw.Write(entero);
                            break;
                        default:
                            throw new Exception("Tipo de dato no permitido");
                    }
                }
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message + "\n" + e1.Source);
            }
        }


        public List<string> Lee(BinaryReader br)
        {
            List<string> devol;
            devol = new List<string>();
            try
            {
                for (int i = 0; i < _numCampos; i++)
                {
                    switch (_tipos[i])
                    {
                        case Tipo.Cadena:
                            devol.Add(br.ReadString());
                            break;
                        case Tipo.Entero:
                            devol.Add(br.ReadInt32().ToString());
                            break;
                        default:
                            throw new Exception("Tipo de dato no permitido");
                    }
                }
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message + "\n" + e1.Source);
            }
            return (devol);
        }
    }
}


