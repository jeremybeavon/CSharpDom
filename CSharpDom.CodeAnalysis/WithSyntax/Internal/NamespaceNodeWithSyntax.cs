using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class NamespaceNodeWithSyntax : NamespaceNode, INamespaceSyntax
    {
        public NamespaceNodeWithSyntax(string name)
            : base(name)
        {
        }

        IReadOnlyCollection<IClassSyntax> IHasClasses<IClassSyntax>.Classes
        {
            get { return new ReadOnlyNodeCollection<IClassSyntax, ClassNode>(Classes); }
        }

        IReadOnlyCollection<NamespaceDeclarationSyntax> IHasDeclarations<NamespaceDeclarationSyntax>.Declarations
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IReadOnlyCollection<IDelegateSyntax> IHasDelegates<IDelegateSyntax>.Delegates
        {
            get { return new ReadOnlyNodeCollection<IDelegateSyntax, DelegateNode>(Delegates); }
        }

        IReadOnlyCollection<IEnumSyntax> IHasEnums<IEnumSyntax>.Enums
        {
            get { return new ReadOnlyNodeCollection<IEnumSyntax, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IInterfaceSyntax> IHasInterfaces<IInterfaceSyntax>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<IInterfaceSyntax, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IStructSyntax> IHasStructs<IStructSyntax>.Structs
        {
            get { return new ReadOnlyNodeCollection<IStructSyntax, StructNode>(Structs); }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new NamespaceWithSyntax(this);
        }
    }
}
