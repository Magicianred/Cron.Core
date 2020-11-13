﻿// ***********************************************************************
// Assembly         : Cron.Core
// Author           : chris
// Created          : 11-12-2020
//
// Last Modified By : chris
// Last Modified On : 11-12-2020
// ***********************************************************************
// <copyright file="ITimeSection.cs" company="Microsoft Corporation">
//     copyright(c) 2020 Christopher Winland
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Cron.Core.Interfaces
{
    /// <summary>
    /// Section specifically for Time (seconds, minutes, hours).
    /// </summary>
    public interface ITimeSection : ISection
    {
        /// <summary>
        /// List of allowed increments when the Every option is used.
        /// </summary>
        /// <value>The allowed increments.</value>
        List<int> AllowedIncrements { get; }
    }
}
