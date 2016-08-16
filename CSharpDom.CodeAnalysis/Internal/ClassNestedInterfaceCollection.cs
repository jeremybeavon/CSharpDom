using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class ClassNestedInterfaceCollection : AbstractClassNestedInterfaceCollection
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal ClassNestedInterfaceCollection(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        protected override IReadOnlyCollection<ClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
