using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassPropertyCollectionWithCodeAnalysis :
        AbstractAbstractClassPropertyCollection<
            ClassPropertyWithCodeAnalysis,
            AbstractPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal AbstractClassPropertyCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<AbstractPropertyWithCodeAnalysis> AbstractProperties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.AbstractPropertiesWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.ExplicitInterfacePropertiesWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<ClassPropertyWithCodeAnalysis> Properties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.PropertiesWithCodeAnalysis; }
        }
    }
}
