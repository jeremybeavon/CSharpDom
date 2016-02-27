using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassMethodCollectionWithMonoCecil :
        AbstractSealedClassMethodCollection<
            SealedClassMethodWithMonoCecil,
            ExplicitInterfaceMethodWithMonoCecil>
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        internal SealedClassMethodCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithMonoCecil> ExplicitInterfaceMethods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.ExplicitInterfaceMethodsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<SealedClassMethodWithMonoCecil> Methods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.MethodsWithMonoCecil; }
        }
    }
}
