using System;
namespace ComposicaoDeObjetos.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        /// <summary>
        /// Método que retorna o valor total do contrato
        /// </summary>
        /// <returns></returns>
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
