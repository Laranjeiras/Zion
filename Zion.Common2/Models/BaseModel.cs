using System;
using Zion.Common2.Enums;
using Zion.Common2.Flunt;

namespace Zion.Common2.Models
{
    public class BaseModel
    {
        public DateTime CriadoEm { get; protected set; } = DateTime.UtcNow;
        public DateTime AtualizadoEm { get; protected set; } = DateTime.UtcNow;
        public eStatusEntidade Status { get; protected set; } = eStatusEntidade.Ativo;

        public readonly Validations Validations;

        public BaseModel()
        {
            Validations = new Validations();
        }
    }
}
