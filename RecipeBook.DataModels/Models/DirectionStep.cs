using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DataModels.Models
{
    /// <summary>
    /// Model for the Direction Step of a Recipe
    /// </summary>
    public class DirectionStep
    {
        /// <summary>
        /// ID of the step
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Display text for the step
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Visual order for the step
        /// </summary>
        public virtual int Order { get; set; }
    }
}
