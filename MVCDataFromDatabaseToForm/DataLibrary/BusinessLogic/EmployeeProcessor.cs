using System;
using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int idEmpregado, string primeiroNome, string ultimoNome, int contacto,
        int numContribuinte, string morada)
        {
            EmployeeModel data = new EmployeeModel
            {
                IDEmpregado = idEmpregado,
                PrimeiroNome = primeiroNome,
                UltimoNome = ultimoNome,
                Contacto = contacto,
                NumContribuinte = numContribuinte,
                Morada = morada
            };

            string sql =
                @"insert into dbo.Employee (IDEmpregado, PrimeiroNome, UltimoNome, Contacto, NumContribuinte, Morada) values (@IDEmpregado, @PrimeiroNome, @UltimoNome, @Contacto, @NumContribuinte, @Morada);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, IDEmpregado, PrimeiroNome, UltimoNome, Contacto, NumContribuinte, Morada
                            from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}

