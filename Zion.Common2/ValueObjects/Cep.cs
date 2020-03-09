using System;
using System.Collections.Generic;
using System.Linq;

namespace Zion.Common2.ValueObjects
{
    public class Cep
    {
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = Cleaner(value); }
        }

        public const int CepMaxLength = 8;

        protected Cep()
        {

        }

        public Cep(string cep)
        {
            if (!IsValid(cep))
                throw new Exception("CEP Inválido");

            Value = cep;
        }

        public static bool IsValid(string cep)
        {
            cep = Cleaner(cep);
            if (Helpers.ZionHelper.IsNullOrEmptyOrWhiteSpace(cep))
                return false;
            
            if (cep.Length != 8)
                return false;
            cep = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
            if (System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}")) == false)
                return false;
            return true;
        }

        public string Simple => GetSimple();

        private string GetSimple()
        {
            if (Value == null)
                return null;

            var tmp = Cleaner(Value.ToString());
            while (tmp.Length < 8)
                tmp = "0" + tmp;
            return tmp;
        }

        public string Formatted => GetFormatted();

        private string GetFormatted()
        {
            if (Value == null)
                return null;

            var cep = Value.ToString();

            while (cep.Length < 8)
                cep = "0" + cep;

            return cep.Substring(0, 5) + "-" + cep.Substring(5);
        }

        private static string Cleaner(string cep)
        {
            return string.IsNullOrEmpty(cep) ? "" : new string(cep.Where(Char.IsDigit).ToArray());
        }

        public override string ToString()
        {
            return GetFormatted();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Cep tmp))
                return false;
            return this.Value == tmp.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
        }

        public static bool operator ==(Cep objetoA, Cep objetoB)
        {
            if (ReferenceEquals(objetoA, null) && ReferenceEquals(objetoB, null))
                return true;

            if (ReferenceEquals(objetoA, null) || ReferenceEquals(objetoB, null))
                return false;

            return true;
        }

        public static bool operator !=(Cep objetoA, Cep objetoB)
        {
            return !(objetoA == objetoB);
        }
    }
}
