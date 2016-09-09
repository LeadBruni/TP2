using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_ej2
{
    class Cliente
    {
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento,string pNombre)
        {
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
            this.iTipoDocumento = pTipoDocumento;
        }

        public TipoDocumento TDocumento { get { return this.iTipoDocumento; } }
        public string NroDocumento { get { return this.iNroDocumento; } }
        public string Nombre { get { return this.iNombre; } }


    }
}
