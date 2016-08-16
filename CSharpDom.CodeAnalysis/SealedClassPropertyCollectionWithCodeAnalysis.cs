using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassPropertyCollectionWithCodeAnalysis :
        AbstractSealedClassPropertyCollection<
            SealedClassPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly SealedTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal SealedClassPropertyCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.ExplicitInterfacePropertiesWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<SealedClassPropertyWithCodeAnalysis> Properties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.PropertiesWithCodeAnalysis; }
        }
    }
}
