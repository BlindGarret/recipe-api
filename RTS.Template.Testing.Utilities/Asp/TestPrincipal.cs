//-----------------------------------------------------------------------
// <copyright file="TestPrincipal.cs" company="Real Technology Solutions">
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
    /// Test implementation of ClaimsPrincipal
    /// </summary>
    [ExcludeFromCodeCoverage]
    [PublicAPI]
    public class TestPrincipal: ClaimsPrincipal
    {
        /// <summary>
        /// ctor
        /// </summary>
        public TestPrincipal(params Claim[] claims) : base(new TestIdentity(claims))
        {
        }
    }
}
