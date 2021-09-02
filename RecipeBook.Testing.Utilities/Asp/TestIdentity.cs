using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using JetBrains.Annotations;

namespace RecipeBook.Testing.Utilities.Asp
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
