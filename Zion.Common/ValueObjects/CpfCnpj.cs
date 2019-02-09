using System;
using System.Collections.Generic;

namespace Zion.Common.ValueObjects
{
    public class CpfCnpj
    {
        public const bool IS_REQUIRED = false;

        public string Value { get; set; }

        public Pessoa Type => Single().Length == 11 ? Pessoa.Fisica : Pessoa.Juridica;

        public enum Pessoa
        {
            Fisica = 0,
            Juridica = 1
        }

        public CpfCnpj()
        {
            Value = null;
        }

        public CpfCnpj(string CpfCnpj)
        {

            if (IsValid(CpfCnpj) == false)
            {
                throw new Exception("Cpf/Cnpj inválido!");
            }

            Value = Clean(CpfCnpj);
        }

        public string Single()
        {
            if (IsValid(Value))
                return Clean(Value);
            return null;
        }

        public string Full()
        {
            if (IsValid(Value) == false || Value == null) return null;

            var tmp = Convert.ToInt64(Single());

            var retorno = string.Empty;
            if (Value.Length == 11)
                retorno = string.Format(@"{0:000\.000\.000\-00}", tmp);
            else if (Value.Length == 14)
                retorno = string.Format(@"{0:00\.000\.000\/0000\-00}", tmp);
            return retorno;
        }

        public string Formatted => Full();

        private static string Clean(string cpfCnpj)
        {
            return Helpers.StringHelper.OnlyNumbers(cpfCnpj);
        }

        public static bool IsValid(string cpfCnpj)
        {
            if (string.IsNullOrEmpty(cpfCnpj) && IS_REQUIRED == false)
                return true;
            else if (string.IsNullOrEmpty(cpfCnpj) && IS_REQUIRED == true)
                return false;

            try
            {
                AssertValidation(cpfCnpj);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static void AssertValidation(string cpfCnpj, string message = "CPF/CNPJ inválido")
        {
            cpfCnpj = Clean(cpfCnpj);

            if (cpfCnpj.Length == 11)
            {
                if (IsValidCpf(cpfCnpj) == false) throw new Exception(message);
            }
            else if (cpfCnpj.Length == 14)
            {
                if (IsValidCnpj(cpfCnpj) == false) throw new Exception(message);
            }
            else
            {
                throw new Exception(message);
            }
        }

        private static bool IsValidCpf(string cpfCnpj)
        {
            var cpf = cpfCnpj;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool IsValidCnpj(string cpfCnpj)
        {
            var cnpj = cpfCnpj;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public override string ToString()
        {
            return Full();
        }

        public override bool Equals(object obj)
        {
            var tmp = obj as CpfCnpj;
            return tmp != null &&
                   Value == tmp.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
        }

        public static bool operator ==(CpfCnpj model1, CpfCnpj model2)
        {
            return EqualityComparer<CpfCnpj>.Default.Equals(model1, model2);
        }

        public static bool operator !=(CpfCnpj model1, CpfCnpj model2)
        {
            return !(model1 == model2);
        }
    }
}
