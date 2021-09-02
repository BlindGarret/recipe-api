using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace RecipeBook.DataModels.Models
{
    /// <summary>
    /// Model for Recipe
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Recipe
    {
        /// <summary>
        /// ID for the recipe
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Title of the recipe
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// URL to image of the recipe
        /// </summary>
        public virtual string ImageUrl { get; set; }

        /// <summary>
        /// Short Description of the recipe
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Longer form notes for the recipe
        /// </summary>
        public virtual string Notes { get; set; }

        /// <summary>
        /// Collection of steps for the recipe
        /// </summary>
        public virtual IList<DirectionStep> Steps { get; set; }

        /// <summary>
        /// List of Ingredients used in the recipe
        /// </summary>
        public virtual IList<IngredientMeasurement> Ingredients { get; set; }

        /// <summary>
        /// Tags for classifying the Recipe
        /// </summary>
        public virtual IList<RecipeTag> Tags { get; set; }

        /// <summary>
        /// Related recipes
        /// </summary>
        public virtual IList<Recipe> RelatedRecipes { get; set; }

        /// <summary>
        /// Variations on the current recipe
        /// </summary>
        public virtual IList<Recipe> Variations { get; set; }

    }
}
