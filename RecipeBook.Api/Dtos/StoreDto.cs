using JetBrains.Annotations;

namespace RecipeBook.Api.Dtos
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
