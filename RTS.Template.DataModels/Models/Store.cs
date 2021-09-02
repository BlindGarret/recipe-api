//-----------------------------------------------------------------------
// <copyright file="Store.cs" company="Real Technology Solutions">
//     Author: blindgarret
//     Copyright (c) 2020 Real Technology Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace RTS.Template.DataModels.Models
{
    [ExcludeFromCodeCoverage]
    public class Store
    {
        public virtual string Id { get; set; }

        public virtual int Number { get; set; }

        public virtual string Name { get; set; }

        public virtual bool IsDormed { get; set; }
    }
}
