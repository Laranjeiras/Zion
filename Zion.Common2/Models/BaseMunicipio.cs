namespace Zion.Common2.Models
{
    public abstract class BaseMunicipio
    {
        public int IdMunicipio { get; protected set; }
        public string Nome { get; protected set; }
        public int IdUF { get; protected set; }

        protected BaseMunicipio()
        {

        }

        protected BaseMunicipio(int idMunicipio, string nome, int idUF)
        {
            IdMunicipio = idMunicipio;
            Nome = nome;
            IdUF = idUF;
        }

        public override string ToString()
        {
            return string.Format("[{0}][{1}] - {2} ", IdMunicipio, IdUF, Nome);
        }

        public override bool Equals(object obj)
        {
            var model = obj as BaseMunicipio;

            return model != null &&
                model.IdMunicipio == IdMunicipio;
        }

        public override int GetHashCode()
        {
            return IdMunicipio * 30;
        }

        public static bool operator ==(BaseMunicipio objetoA, BaseMunicipio objetoB)
        {
            if (ReferenceEquals(objetoA, null) && ReferenceEquals(objetoB, null))
                return true;

            if (ReferenceEquals(objetoA, null) || ReferenceEquals(objetoB, null))
                return false;

            return true;
        }

        public static bool operator !=(BaseMunicipio objetoA, BaseMunicipio objetoB)
        {
            return !(objetoA == objetoB);
        }
    }
}
