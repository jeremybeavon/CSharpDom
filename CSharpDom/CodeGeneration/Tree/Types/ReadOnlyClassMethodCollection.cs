using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassMethodCollection :
        AbstractClassMethodCollection<ReadOnlyClassMethod, ReadOnlyExplicitInterfaceMethod>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassMethod> methods;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceMethod> explicitInterfaceMethods;

        public ReadOnlyClassMethodCollection(ClassBody body)
        {
            methods = body.Methods.ToArray(method => new ReadOnlyClassMethod(method));
            explicitInterfaceMethods = body.ExplicitInterfaceMethods.ToArray(method => new ReadOnlyExplicitInterfaceMethod(method));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceMethod> ExplicitInterfaceMethods
        {
            get { return explicitInterfaceMethods; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassMethod> Methods
        {
            get { return methods; }
        }
    }
}
