﻿using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        // Associação entre duas classes
        public Department Department { get; set; }
        
        // Associação com lista
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        
        
        public Worker()
        {
        }

        //Construtor sem Contracts(pois é lista)
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
