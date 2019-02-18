namespace Zion.Common.Models
{
    public abstract class BaseMunicipio
    {
        public int IdMunicipio { get; protected set; }

        public string Name { get; protected set; }

        public int IdUF { get; protected set; }

        public BaseUF UF { get; set; }

        protected BaseMunicipio()
        {

        }

        public BaseMunicipio(int idMunicipio, string name, BaseUF uf)
        {
            IdMunicipio = idMunicipio;
            Name = name;
            IdUF = uf.IdUF;
            UF = uf;
        }

        public override string ToString()
        {
            return string.Format("[{0}] - {1}", UF?.Initials, Name);
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