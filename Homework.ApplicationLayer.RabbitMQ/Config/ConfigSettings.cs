﻿// Copyright (c) 2021 Maxim Kuzmin. All rights reserved. Licensed under the MIT License.

namespace Homework.ApplicationLayer.RabbitMQ.Config
{
    /// <summary>
    /// Настройки конфигурации.
    /// </summary>
    public class ConfigSettings : IConfigSettings
    {
        #region Properties

        /// <inheritdoc/>
        public string HostName { get; set; }

        /// <inheritdoc/>
        public string Queue { get; set; }

        #endregion Properties
    }
}
