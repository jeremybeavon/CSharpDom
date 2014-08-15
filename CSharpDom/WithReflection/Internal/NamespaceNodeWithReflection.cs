using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;

namespace CSharpDom.WithReflection.Internal
{
    internal class NamespaceNodeWithReflection : NamespaceNodeWithSymbols, INamespaceWithReflection
    {
        public NamespaceNodeWithReflection(string name)
            : base(name)
        {
        }

        public INamespaceWithSymbols Symbols
        {
            get { return this; }
        }

        IReadOnlyCollection<IClassWithReflection> IHasClasses<IClassWithReflection>.Classes
        {
            get { return new ReadOnlyNodeCollection<IClassWithReflection, ClassNode>(Classes); }
        }

        IReadOnlyCollection<IDelegateWithReflection> IHasDelegates<IDelegateWithReflection>.Delegates
        {
            get { return new ReadOnlyNodeCollection<IDelegateWithReflection, DelegateNode>(Delegates); }
        }

        IReadOnlyCollection<IEnumWithReflection> IHasEnums<IEnumWithReflection>.Enums
        {
            get { return new ReadOnlyNodeCollection<IEnumWithReflection, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IInterfaceWithReflection> IHasInterfaces<IInterfaceWithReflection>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<IInterfaceWithReflection, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IStructWithReflection> IHasStructs<IStructWithReflection>.Structs
        {
            get { return new ReadOnlyNodeCollection<IStructWithReflection, StructNode>(Structs); }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
