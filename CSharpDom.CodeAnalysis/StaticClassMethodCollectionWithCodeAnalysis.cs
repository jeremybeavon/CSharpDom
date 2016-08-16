using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassMethodCollectionWithCodeAnalysis :
        AbstractStaticClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StaticClassMethodCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ExtensionMethodWithCodeAnalysis> ExtensionMethods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.ExtensionMethodsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StaticClassMethodWithCodeAnalysis> Methods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.MethodsWithCodeAnalysis; }
        }
    }
}
