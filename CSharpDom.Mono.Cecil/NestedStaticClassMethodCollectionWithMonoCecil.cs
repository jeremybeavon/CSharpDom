using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NestedStaticClassMethodCollectionWithMonoCecil :
        AbstractNestedStaticClassMethodCollection<StaticClassMethodWithMonoCecil>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal NestedStaticClassMethodCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        protected override IReadOnlyCollection<StaticClassMethodWithMonoCecil> Methods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.MethodsWithMonoCecil; }
        }
    }
}
