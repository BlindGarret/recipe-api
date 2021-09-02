using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;
using RecipeBook.DataModels.Models;

namespace RecipeBook.DataMappings.Mappings
{
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    public class IngredientMap: ClassMapping<Ingredient>
    {
        public IngredientMap()
        {
            Table("ingredients");

            Id(x => x.Name, x =>
            {
                x.Type(NHibernateUtil.StringClob);
                x.Column("name");
                x.Length(100);
            });

            Bag(x => x.Tags, map =>
            {
                map.Table("ingedient_tag_links");
                map.Key(k => k.Column(col => col.Name("tag_id")));

            }, x => x.ManyToMany(k => k.Column(col => col.Name("ingredient_id"))));
        }
    }
}
