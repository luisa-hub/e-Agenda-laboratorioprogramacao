using System.ComponentModel;

namespace eAgenda.Dominio.TarefaModule
{
    /// <summary>
    /// Enum com o tipo de prioridade da Tarefa
    /// </summary>
    public enum PrioridadeEnum : int
    {
        [Description("Prioridade Baixa")]
        Baixa = 0,

        [Description("Prioridade Normal")]
        Normal = 1,

        [Description("Prioridade Alta")]
        Alta = 2
    }
}