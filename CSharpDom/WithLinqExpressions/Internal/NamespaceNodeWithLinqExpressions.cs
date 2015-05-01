using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class NamespaceNodeWithLinqExpressions : NamespaceNodeWithReflection, INamespaceWithLinqExpressions
    {
        public NamespaceNodeWithLinqExpressions(string name)
            : base(name)
        {
        }

        public INamespaceWithReflection Reflection
        {
            get { return this; }
        }

        IReadOnlyCollection<IClassWithLinqExpressions> IHasClasses<IClassWithLinqExpressions>.Classes
        {
            get { return new ReadOnlyNodeCollection<IClassWithLinqExpressions, ClassNode>(Classes); }
        }

        IReadOnlyCollection<IDelegateWithLinqExpressions> IHasDelegates<IDelegateWithLinqExpressions>.Delegates
        {
            get { return new ReadOnlyNodeCollection<IDelegateWithLinqExpressions, DelegateNode>(Delegates); }
        }

        IReadOnlyCollection<IEnumWithLinqExpressions> IHasEnums<IEnumWithLinqExpressions>.Enums
        {
            get { return new ReadOnlyNodeCollection<IEnumWithLinqExpressions, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IInterfaceWithLinqExpressions> IHasInterfaces<IInterfaceWithLinqExpressions>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<IInterfaceWithLinqExpressions, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IStructWithLinqExpressions> IHasStructs<IStructWithLinqExpressions>.Structs
        {
            get { return new ReadOnlyNodeCollection<IStructWithLinqExpressions, StructNode>(Structs); }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
