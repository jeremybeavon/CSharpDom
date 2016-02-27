using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassMethodCollectionWithMonoCecil :
        AbstractClassMethodCollection<ClassMethodWithMonoCecil, ExplicitInterfaceMethodWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal ClassMethodCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithMonoCecil> ExplicitInterfaceMethods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.ExplicitInterfaceMethodsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<ClassMethodWithMonoCecil> Methods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.MethodsWithMonoCecil; }
        }
    }
}
