//-----------------------------------------------------------------------
// <copyright file="TestIdentity.cs" company="Real Technology Solutions">
//     Author: blindgarret
//     Copyright (c) 2021 Real Technology Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using JetBrains.Annotations;

namespace RTS.Template.Testing.Utilities.Asp
{
    /// <summary>
    /// Test implementation of ClaimsIdentity
    /// </summary>
    [ExcludeFromCodeCoverage]
    [PublicAPI]
    public class TestIdentity: ClaimsIdentity
    {
        /// <summary>
        /// ctor
        /// </summary>
        public TestIdentity(params Claim[] claims) : base(claims)
        {
        }
    }
}
