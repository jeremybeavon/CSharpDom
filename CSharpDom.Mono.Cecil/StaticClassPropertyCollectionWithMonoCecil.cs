using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassPropertyCollectionWithMonoCecil :
        AbstractStaticClassPropertyCollection<
            StaticClassPropertyWithMonoCecil,
            PropertyNotSupported,
            PropertyNotSupported>
    {
        private readonly Lazy<IReadOnlyCollection<StaticClassPropertyWithMonoCecil>> properties;

        internal StaticClassPropertyCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            properties = new Lazy<IReadOnlyCollection<StaticClassPropertyWithMonoCecil>>(
                () => typeWithMonoCecil.PropertyCollection.Properties.PropertiesWithMonoCecil);
        }
        
        public override IReadOnlyCollection<PropertyNotSupported> AutoProperties => new PropertyNotSupported[0];

        public override IReadOnlyCollection<PropertyNotSupported> LambdaProperties => new PropertyNotSupported[0];

        protected override IReadOnlyCollection<StaticClassPropertyWithMonoCecil> Properties
        {
            get { return properties.Value; }
        }
    }
}
