using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassMethodCollectionWithMonoCecil :
        AbstractStaticClassMethodCollection<
            StaticClassMethodWithMonoCecil,
            ExtensionMethodWithMonoCecil>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassMethodCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExtensionMethodWithMonoCecil> ExtensionMethods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.ExtensionMethodsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<StaticClassMethodWithMonoCecil> Methods
        {
            get { return typeWithMonoCecil.MethodCollection.Methods.MethodsWithMonoCecil; }
        }
    }
}
