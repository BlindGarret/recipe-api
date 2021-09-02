using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace RecipeBook.Testing.Utilities.Nhibernate
{
    /// <summary>
    /// Implementation of IQueryable for mocking out queryables during testing
    /// Found @ https://stackoverflow.com/a/61420204/7846220 modified slightly to allow for collection initialization
    /// </summary>
    /// <typeparam name="T">The type for the queryable</typeparam>
    [ExcludeFromCodeCoverage]
    [PublicAPI]
    public class TestingQueryable<T>: IQueryable<T>
    {
        private readonly List<T> _collection = new();

        private readonly IQueryable<T> _overrideQueryable;

        private IQueryable<T> Queryable => _overrideQueryable ?? _collection.AsQueryable();

        /// <summary>
        /// Default CTOR
        /// </summary>
        public TestingQueryable()
        {
            
        }

        /// <summary>
        /// Queryable CTOR
        /// </summary>
        public TestingQueryable(IQueryable<T> queryable)
        {
            _overrideQueryable = queryable;
        }

        public TestingQueryable(IEnumerable<T> enumerable)
        {
            _collection = new List<T>(enumerable);
        }

        /// <inheritdoc />
        public Type ElementType => Queryable.ElementType;

        /// <inheritdoc />
        public Expression Expression => Queryable.Expression;

        /// <inheritdoc />
        public IQueryProvider Provider => new TestingQueryProvider<T>(Queryable);

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator()
        {
            return Queryable.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Queryable.GetEnumerator();
        }

        public void Add(T value)
        {
            _collection.Add(value);
        }
    }
}
