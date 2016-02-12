using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassPropertyCollectionWithReflection :
        AbstractClassPropertyCollection<ClassPropertyWithReflection, ExplicitInterfacePropertyWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassPropertyCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return typeWithReflection.PropertyCollection.Properties.ExplicitInterfacePropertiesWithReflection; }
        }

        protected override IReadOnlyCollection<ClassPropertyWithReflection> Properties
        {
            get { return typeWithReflection.PropertyCollection.Properties.PropertiesWithReflection; }
        }
    }
}
