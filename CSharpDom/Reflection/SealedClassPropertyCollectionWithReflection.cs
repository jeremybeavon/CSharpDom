using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassPropertyCollectionWithReflection :
        AbstractSealedClassPropertyCollection<
            SealedClassPropertyWithReflection,
            ExplicitInterfacePropertyWithReflection>
    {
        private readonly SealedTypeWithReflection typeWithReflection;

        internal SealedClassPropertyCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return typeWithReflection.PropertyCollection.Properties.ExplicitInterfacePropertiesWithReflection; }
        }

        protected override IReadOnlyCollection<SealedClassPropertyWithReflection> Properties
        {
            get { return typeWithReflection.PropertyCollection.Properties.PropertiesWithReflection; }
        }
    }
}
