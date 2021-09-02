//-----------------------------------------------------------------------
// <copyright file="StoreMap.cs" company="Real Technology Solutions">
//     Author: blindgarret
//     Copyright (c) 2020 Real Technology Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;
using RTS.Template.DataModels.Models;

namespace RTS.Template.DataMappings.Mappings
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
