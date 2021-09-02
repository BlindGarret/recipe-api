using System.Collections.Generic;

namespace RecipeBook.DataModels.Models
{
    /// <summary>
    /// Model for Ingredients
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Name of the ingredient
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Tags for an ingredient for categorization
        /// </summary>
        public virtual IList<IngredientTag> Tags { get; set; }
    }
}
