//-----------------------------------------------------------------------
// <copyright file="StoreDto.cs" company="Real Technology Solutions">
//     Author: blindgarret
//     Copyright (c) 2020 Real Technology Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using JetBrains.Annotations;

namespace RTS.Template.API.Dtos
{
    /// <summary>
    /// Example VM
    /// </summary>
    [PublicAPI]
    public class StoreDto
    {
        /// <summary>
        /// 2-3 Character Id for the store
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Numeric Id for the store
        /// </summary>
        public virtual int Number { get; set; }

        /// <summary>
        /// Name of the store
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Flag for whether to use the dormed workflow for the store
        /// </summary>
        public virtual bool IsDormed { get; set; }
    }
}
