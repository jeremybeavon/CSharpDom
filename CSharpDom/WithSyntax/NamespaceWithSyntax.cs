using System.Collections.Generic;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class NamespaceWithSyntax : AbstractSyntaxNode<INamespaceSyntax>
    {
        private readonly INamespaceSyntax @namespace;

        public NamespaceWithSyntax(INamespaceSyntax @namespace)
            : base(@namespace)
        {
            this.@namespace = @namespace;
        }

        public IReadOnlyCollection<ClassWithSyntax> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassWithSyntax, IClassSyntax>(
                    @namespace.Classes,
                    @class => new ClassWithSyntax(@class));
            }
        }

        public IEnumerable<NamespaceDeclarationSyntax> Declarations
        {
            get { return @namespace.Declarations; }
        }

        public IReadOnlyCollection<DelegateWithSyntax> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<DelegateWithSyntax, IDelegateSyntax>(
                    @namespace.Delegates,
                    @delegate => new DelegateWithSyntax(@delegate));
            }
        }

        public IReadOnlyCollection<EnumWithSyntax> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumWithSyntax, IEnumSyntax>(
                    @namespace.Enums,
                    @enum => new EnumWithSyntax(@enum));
            }
        }

        public IReadOnlyCollection<InterfaceWithSyntax> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceWithSyntax, IInterfaceSyntax>(
                    @namespace.Interfaces,
                    @interface => new InterfaceWithSyntax(@interface));
            }
        }

        public string Name
        {
            get { return @namespace.Name; }
        }

        public IReadOnlyCollection<StructWithSyntax> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<StructWithSyntax, IStructSyntax>(
                    @namespace.Structs,
                    @struct => new StructWithSyntax(@struct));
            }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @namespace.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNamespace(this);
        }
    }
}
