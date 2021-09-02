using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Type;

namespace RecipeBook.Testing.Utilities.Nhibernate
{
    /// <summary>
    /// Implementation of INhQueryProvider for mocking out queryables during testing
    /// Found @ https://stackoverflow.com/a/61420204/7846220
    /// </summary>
    /// <typeparam name="T">The type for the queryable</typeparam>
    [ExcludeFromCodeCoverage]
    [PublicAPI]
    public class TestingQueryProvider<T>: INhQueryProvider
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public TestingQueryProvider(IQueryable<T> source)
        {
            Source = source;
        }

        /// <summary>
        /// Source queryable
        /// </summary>
        public IQueryable<T> Source { get; set; }

        /// <inheritdoc />
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new TestingQueryable<TElement>(Source.Provider.CreateQuery<TElement>(expression));
        }

        /// <inheritdoc />
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public TResult Execute<TResult>(Expression expression)
        {
            return Source.Provider.Execute<TResult>(expression);
        }

        /// <inheritdoc />
        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute<TResult>(expression));
        }

        /// <inheritdoc />
        public int ExecuteDml<T1>(QueryMode queryMode, Expression expression)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<int> ExecuteDmlAsync<T1>(QueryMode queryMode, Expression expression, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IFutureEnumerable<TResult> ExecuteFuture<TResult>(Expression expression)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IFutureValue<TResult> ExecuteFutureValue<TResult>(Expression expression)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetResultTransformerAndAdditionalCriteria(IQuery query, NhLinqExpression nhExpression, IDictionary<string, Tuple<object, IType>> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
