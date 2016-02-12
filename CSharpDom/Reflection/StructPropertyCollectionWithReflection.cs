using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructPropertyCollectionWithReflection :
        AbstractStructPropertyCollection<StructPropertyWithReflection, ExplicitInterfacePropertyWithReflection>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructPropertyCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return typeWithReflection.Properties.Properties.ExplicitInterfacePropertiesWithReflection; }
        }

        protected override IReadOnlyCollection<StructPropertyWithReflection> Properties
        {
            get { return typeWithReflection.Properties.Properties.PropertiesWithReflection; }
        }
    }
}
