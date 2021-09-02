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
    public class DirectionStepMap: ClassMapping<DirectionStep>
    {
        public DirectionStepMap()
        {
            Table("direction_steps");

            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("id");
                x.Generator(Generators.Increment);
            });

            Property(x => x.Text, x =>
            {
                x.Type(NHibernateUtil.StringClob);
                x.Column(c =>
                {
                    c.Name("text");
                    c.Length(2048);
                });
                x.NotNullable(true);
            });

            Property(x => x.Order, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column(c =>
                {
                    c.Name("order");
                    c.Default(0);
                });
                x.NotNullable(true);
            });

        }
    }
}
