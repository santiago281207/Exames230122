using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exames230122
{
    public class Inscricao
    {
        DateTime m_data;
        public int numero { get; set; }

        public Inscricao(DateTime data,int numero)
        {
            this.m_data = data;
            this.numero = numero;
        }

        public DateTime GetData()
        {
            return m_data;
        }
    }
}
