using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassPropertyCollectionWithReflection :
        AbstractStaticClassPropertyCollection<
            StaticClassPropertyWithReflection,
            PropertyNotSupported,
            PropertyNotSupported>
    {
        private readonly Lazy<IReadOnlyCollection<StaticClassPropertyWithReflection>> properties;

        internal StaticClassPropertyCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            properties = new Lazy<IReadOnlyCollection<StaticClassPropertyWithReflection>>(
                () => typeWithReflection.PropertyCollection.Properties.PropertiesWithReflection);
        }
        
        public override IReadOnlyCollection<PropertyNotSupported> AutoProperties => new PropertyNotSupported[0];

        public override IReadOnlyCollection<PropertyNotSupported> LambdaProperties => new PropertyNotSupported[0];

        protected override IReadOnlyCollection<StaticClassPropertyWithReflection> Properties
        {
            get { return properties.Value; }
        }
    }
}
