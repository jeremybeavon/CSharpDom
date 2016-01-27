using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class NamespaceNodeWithSymbols : NamespaceNodeWithSyntax, INamespaceWithSymbols
    {
        public NamespaceNodeWithSymbols(string name)
            : base(name)
        {
        }

        public INamespaceSyntax Syntax
        {
            get { return this; }
        }

        IReadOnlyCollection<IClassWithSymbols> IHasClasses<IClassWithSymbols>.Classes
        {
            get { return new ReadOnlyNodeCollection<IClassWithSymbols, ClassNode>(Classes); }
        }

        IReadOnlyCollection<IDelegateWithSymbols> IHasDelegates<IDelegateWithSymbols>.Delegates
        {
            get { return new ReadOnlyNodeCollection<IDelegateWithSymbols, DelegateNode>(Delegates); }
        }

        IReadOnlyCollection<IEnumWithSymbols> IHasEnums<IEnumWithSymbols>.Enums
        {
            get { return new ReadOnlyNodeCollection<IEnumWithSymbols, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IInterfaceWithSymbols> IHasInterfaces<IInterfaceWithSymbols>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<IInterfaceWithSymbols, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IStructWithSymbols> IHasStructs<IStructWithSymbols>.Structs
        {
            get { return new ReadOnlyNodeCollection<IStructWithSymbols, StructNode>(Structs); }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
