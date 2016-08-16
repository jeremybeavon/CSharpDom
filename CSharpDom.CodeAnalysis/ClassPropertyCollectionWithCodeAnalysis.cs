using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassPropertyCollectionWithCodeAnalysis :
        AbstractClassPropertyCollection<ClassPropertyWithCodeAnalysis, ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal ClassPropertyCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
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
