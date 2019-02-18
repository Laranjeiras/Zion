using System;
using Zion.Common.Assertions;

namespace Zion.Common.Models
{
    public abstract class BaseUF
    {
        protected BaseUF()
        {

        }

        public BaseUF(int idUF, string initials, string name)
        {
            IdUF = idUF;
            Initials = initials;
            Nome = name;
        }

        public int IdUF { get; set; }

        private string _initials;
        public string Initials {
            get { return _initials; }
            set
            {
                try
                {
                    ZionAssertion.StringHasLen(value, 2, "Sigla inválida");
                    _initials = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string Nome { get; set; }
    }
}
