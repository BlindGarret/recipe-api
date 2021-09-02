namespace RecipeBook.DataModels.Models
{
    /// <summary>
    /// Model for Ingredient Measurement Combination in a Recipe
    /// </summary>
    public class IngredientMeasurement
    {
        /// <summary>
        /// ID of the IM
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// The Ingredient being referenced
        /// </summary>
        public virtual Ingredient Ingredient { get; set; }

        /// <summary>
        /// The value for the measurement
        /// </summary>
        public virtual string Value { get; set; }

        /// <summary>
        /// The unit of measurement
        /// </summary>
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        /// <summary>
        /// Visual order for the ingredient
        /// </summary>
        public virtual int Order { get; set; }
    }
}
