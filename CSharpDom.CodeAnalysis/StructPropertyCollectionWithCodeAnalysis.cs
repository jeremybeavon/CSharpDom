using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructPropertyCollectionWithCodeAnalysis :
        AbstractStructPropertyCollection<StructPropertyWithCodeAnalysis, ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructPropertyCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.ExplicitInterfacePropertiesWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StructPropertyWithCodeAnalysis> Properties
        {
            get { return typeWithCodeAnalysis.PropertyCollection.Properties.PropertiesWithCodeAnalysis; }
        }
    }
}
