using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RecipeBook.DataModels.Models;

namespace RecipeBook.DataMappings.Mappings
{
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    public class IngredientMeasurementMap: ClassMapping<IngredientMeasurement>
    {
        public IngredientMeasurementMap()
        {
            Table("ingredient_measurements");

            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("id");
                x.Generator(Generators.Increment);
            });

            ManyToOne(x => x.Ingredient, map =>
            {
                map.Cascade(Cascade.None);
                map.Column("ingredient");
            });

            Property(x => x.Value, x =>
            {
                x.Type(NHibernateUtil.StringClob);
                x.Column(c =>
                {
                    c.Name("value");
                    c.Length(25);
                });
                x.NotNullable(true);
            });

            ManyToOne(x => x.UnitOfMeasure, map =>
            {
                map.Cascade(Cascade.None);
                map.Column("uom");
            });

            Property(x => x.Order, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column(c =>
                {
                    c.Name("order");
                });
                x.NotNullable(true);
            });
        }
    }
}
