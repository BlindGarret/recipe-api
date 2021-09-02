using System.Diagnostics;
using NHibernate;
using NHibernate.SqlCommand;

namespace RecipeBook.Api.Database
{
    /// <summary>
    /// Debug output interceptor which console logs any SQL statements made
    /// </summary>
    public class SqlDebugOutputInterceptor : EmptyInterceptor
    {
        /// <summary>
        /// On Prepare hook for statements
        /// </summary>
        /// <param name="sql"><see cref="SqlString"/></param>
        /// <returns><see cref="SqlString"/></returns>
        public override SqlString OnPrepareStatement(SqlString sql)
        {
            Debug.WriteLine($"NHibernate: {sql}");
            return base.OnPrepareStatement(sql);
        }
    }
}
