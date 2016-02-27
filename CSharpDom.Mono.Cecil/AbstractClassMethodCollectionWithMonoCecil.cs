using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractClassMethodCollectionWithMonoCecil :
        AbstractAbstractClassMethodCollection<
            ClassMethodWithMonoCecil,
            AbstractMethodWithMonoCecil,
            ExplicitInterfaceMethodWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal AbstractClassMethodCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<AbstractMethodWithMonoCecil> AbstractMethods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.AbstractMethodsWithMonoCecil; }
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
