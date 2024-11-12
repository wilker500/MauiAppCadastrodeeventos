using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastrodeeventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Calcula a duração do evento em dias
        public int Duracao => (DataTermino - DataInicio).Days + 1;

        // Calcula o custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante * Duracao;
    }
}
