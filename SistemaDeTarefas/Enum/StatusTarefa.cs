﻿using System.ComponentModel;

namespace SistemaDeTarefas.Enum
{
    public enum StatusTarefa
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido =3
    }
}
