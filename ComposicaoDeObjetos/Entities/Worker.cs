using System.Collections.Generic;
using ComposicaoDeObjetos.Entities.Enums;

namespace ComposicaoDeObjetos.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Associação de objetos
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação de objetos

        // Lista instaciada para garantir que não seja nula (new List())
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); 

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        /// <summary>
        /// Função que recebe um contrato por parâmetro e adiciona o mesmo na lista de contratos do trabalhador
        /// </summary>
        /// <param name="contract"></param>
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        /// <summary>
        /// Função que recebe um contrato por parâmetro e remove o mesmo da lista de contratos do trabalhador
        /// </summary>
        /// <param name="contract"></param>
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        /// <summary>
        /// Função que recebe o mês e o ano do contrato como parâmetro, percorre a lista de contratos, verifica se os dados estão na lista, 
        /// soma os valores e retorna a soma total dos contratos de acordo com os parâmetros fornecidos.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                // Verifica se o ano e o mês do contrato é igual aos que recebeu como parâmetro
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum; // Soma total dos contratos que será retornada
        }
    }
}
