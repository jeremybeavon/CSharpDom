using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructMethodCollection :
        AbstractStructMethodCollection<ReadOnlyStructMethod, ReadOnlyExplicitInterfaceMethod>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructMethod> methods;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceMethod> explicitInterfaceMethods;

        public ReadOnlyStructMethodCollection(StructBody body)
        {
            methods = body.Methods.ToArray(method => new ReadOnlyStructMethod(method));
            explicitInterfaceMethods = body.ExplicitInterfaceMethods.ToArray(method => new ReadOnlyExplicitInterfaceMethod(method));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceMethod> ExplicitInterfaceMethods
        {
            get { return explicitInterfaceMethods; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructMethod> Methods
        {
            get { return methods; }
        }
    }
}
