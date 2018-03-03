using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class AbstractClassPropertyCollectionWithReflection :
        AbstractAbstractClassPropertyCollection<
            ClassPropertyWithReflection,
            PropertyNotSupported,
            PropertyNotSupported,
            AbstractPropertyWithReflection,
            ExplicitInterfacePropertyWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal AbstractClassPropertyCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<AbstractPropertyWithReflection> AbstractProperties
        {
            get { return typeWithReflection.PropertyCollection.Properties.AbstractPropertiesWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return typeWithReflection.PropertyCollection.Properties.ExplicitInterfacePropertiesWithReflection; }
        }

        public override IReadOnlyCollection<PropertyNotSupported> AutoProperties => new PropertyNotSupported[0];

        public override IReadOnlyCollection<PropertyNotSupported> LambdaProperties => new PropertyNotSupported[0];

        protected override IReadOnlyCollection<ClassPropertyWithReflection> Properties
        {
            get { return typeWithReflection.PropertyCollection.Properties.PropertiesWithReflection; }
        }
    }
}
