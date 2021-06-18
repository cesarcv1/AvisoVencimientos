using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace rDocumentos
{

    class ComboDias
    {
        public void Cargar_Dias(ComboBox cb)
        {
            cb.Items.Insert(0, "15");
            int numero = 1;
            cb.Items.Clear();
            while (numero <= 15)
            {
                cb.Items.Add(numero);
                numero++;
            }
            cb.SelectedIndex = 14;
        }
    }
}
