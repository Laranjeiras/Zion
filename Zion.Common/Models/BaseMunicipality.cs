namespace Zion.Common.Models
{
    public abstract class BaseMunicipality
    {
        public int IdMunicipality { get; protected set; }

        public string Name { get; protected set; }

        public int IdUF { get; protected set; }

        public BaseUF UF { get; set; }

        protected BaseMunicipality()
        {

        }

        public BaseMunicipality(int idMunicipality, string name, BaseUF uf)
        {
            IdMunicipality = idMunicipality;
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
            var model = obj as BaseMunicipality;

            return model != null &&
                model.IdMunicipality == IdMunicipality;
        }

        public override int GetHashCode()
        {
            return IdMunicipality * 30;
        }

        public static bool operator ==(BaseMunicipality objetoA, BaseMunicipality objetoB)
        {
            if (ReferenceEquals(objetoA, null) && ReferenceEquals(objetoB, null))
                return true;

            if (ReferenceEquals(objetoA, null) || ReferenceEquals(objetoB, null))
                return false;

            return true;
        }

        public static bool operator !=(BaseMunicipality objetoA, BaseMunicipality objetoB)
        {
            return !(objetoA == objetoB);
        }
    }
}