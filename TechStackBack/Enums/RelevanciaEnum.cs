using System.ComponentModel;

namespace TechStackBack.Enums
{
    public enum RelevanciaEnum
    {
        [Description("Desconhecido")] Desconhecido = 0,
        [Description("Teórico")] Teorico = 1,
        [Description("Básico")] Basico = 2,
        [Description("Intermediário")] Intermediario = 3,
        [Description("Avançado")] Avancado = 4,
        [Description("Especialista")] Especialista = 5,
    }
}
