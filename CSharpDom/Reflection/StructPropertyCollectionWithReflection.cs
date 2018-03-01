using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructPropertyCollectionWithReflection :
        AbstractStructPropertyCollection<
            StructPropertyWithReflection,
            PropertyNotSupported,
            PropertyNotSupported,
            ExplicitInterfacePropertyWithReflection>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructPropertyCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return typeWithReflection.PropertyCollection.Properties.ExplicitInterfacePropertiesWithReflection; }
        }

        public override IReadOnlyCollection<PropertyNotSupported> AutoProperties => new PropertyNotSupported[0];

        public override IReadOnlyCollection<PropertyNotSupported> LambdaProperties => new PropertyNotSupported[0];

        protected override IReadOnlyCollection<StructPropertyWithReflection> Properties
        {
            get { return typeWithReflection.PropertyCollection.Properties.PropertiesWithReflection; }
        }
    }
}
