﻿namespace EmbyStat.Common.Tasks.Interface
{
    public interface IConfigurableScheduledTask
    {
        bool IsEnabled { get; }
        bool IsLogged { get; }
    }
}
