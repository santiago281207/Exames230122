using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Exames230122
{
    public class Exame
    {
        Inscricao[] m_presencas;
        string m_sigla;
        int m_qtd;
        int m_dim = 28;

        public int GetDim()
        {
            return m_dim;
        }
        public string GetSigla()
        {
            return m_sigla;
        }
        public int GetQtd()
        {
            return m_qtd;
        }
        public Exame(string sigla)
        {
            m_sigla = sigla;
            m_presencas = new Inscricao[m_dim];
            m_qtd = 0;
        }
        public void GetIndexValues(int index,out int numero,out DateTime data)
        {
            numero = m_presencas[index].numero;
            data = m_presencas[index].GetData();
        }
        public void Add(int numero, DateTime data)
        {
            Inscricao insc = new Inscricao(data, numero);
            m_presencas[m_qtd] = insc;
            m_qtd++;
        }

        public bool CheckRepetido(int numero,DateTime data)
        {
            for(int i = 0; i < m_qtd;i++)
            {
                if (m_presencas[i].numero == numero && m_presencas[i].GetData() == data)
                {
                    return true;
                }
            }
            return false;
        }

        public int AlunosPorData(DateTime data)
        {
            int soma = 0;

            for(int i = 0;i < m_qtd;i++)
            {
                if (m_presencas[i].GetData().Date == data)
                {
                    soma++;
                }
            }

            return soma;
        }
    }
}
