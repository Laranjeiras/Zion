using System.ComponentModel;

namespace Zion.Common2.Enums
{
    [System.Flags]
    public enum eStatusEntidade
    {
        [Description("Excluído")]
        Excluido = 0,
        [Description("Ativo")]
        Ativo = 1,
        [Description("Bloqueado")]
        Bloqueado = 2,
        [Description("Aguardando aprovação")]
        AguardandoAprovacao = 3,
        [Description("Excluído")]
        Deletado = 8
    }
}
