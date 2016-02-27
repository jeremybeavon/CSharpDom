using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructMethodCollectionWithMonoCecil :
        AbstractStructMethodCollection<StructMethodWithMonoCecil, ExplicitInterfaceMethodWithMonoCecil>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructMethodCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithMonoCecil> ExplicitInterfaceMethods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.ExplicitInterfaceMethodsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<StructMethodWithMonoCecil> Methods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.MethodsWithMonoCecil; }
        }
    }
}
