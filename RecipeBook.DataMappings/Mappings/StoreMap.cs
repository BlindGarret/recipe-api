using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;
using RecipeBook.DataModels.Models;

namespace RecipeBook.DataMappings.Mappings
{
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    public class StoreMap : ClassMapping<Store>
    {
        public StoreMap()
        {
            Table("stores"); 
            
            Id(x => x.Id, x =>
            {
                x.Length(3);
                x.Type(NHibernateUtil.StringClob);
                x.Column("id");
                x.UnsavedValue("");
            });

            Property(x => x.Number, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column(c =>
                {
                    c.Name("number");
                });
                x.NotNullable(true);
            });

            Property(x => x.Name, x =>
            {
                x.Length(128);
                x.Type(NHibernateUtil.StringClob);
                x.Column(c =>
                {
                    c.Name("name");
                });
                x.NotNullable(true);
            });

            Property(x => x.IsDormed, x =>
            {
                x.Type(NHibernateUtil.Boolean);
                x.Column(c =>
                {
                    c.Name("is_dormed");
                });
                x.NotNullable(true);
            });
        }
    }
}
