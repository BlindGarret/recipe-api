using System.Diagnostics.CodeAnalysis;

namespace RecipeBook.DataModels.Models
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
