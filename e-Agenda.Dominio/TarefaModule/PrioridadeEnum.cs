using System.ComponentModel;

namespace eAgenda.Dominio.TarefaModule
{
    /// <summary>
    /// Enum com o tipo de prioridade da Tarefa
    /// </summary>
    public enum PrioridadeEnum : int
    {
        [Description("Baixa")]
        Baixa = 0,

        [Description("Normal")]
        Normal = 1,

        [Description("Alta")]
        Alta = 2
    }
}