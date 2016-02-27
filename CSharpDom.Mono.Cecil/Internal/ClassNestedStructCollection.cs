using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class ClassNestedStructCollection : AbstractClassNestedStructCollection
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal ClassNestedStructCollection(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        protected override IReadOnlyCollection<ClassNestedStructWithMonoCecil> Structs
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
