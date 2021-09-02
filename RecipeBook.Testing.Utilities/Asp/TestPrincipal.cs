using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using JetBrains.Annotations;

namespace RecipeBook.Testing.Utilities.Asp
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
