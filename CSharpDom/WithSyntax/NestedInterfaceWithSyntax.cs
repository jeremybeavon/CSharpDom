using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedInterfaceWithSyntax : BasicTypeWithSyntax
    {
        private readonly INestedInterfaceSyntax @interface;

        public NestedInterfaceWithSyntax(INestedInterfaceSyntax @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<NestedInterfaceDeclarationWithSyntax> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceDeclarationWithSyntax, INestedInterfaceDeclarationSyntax>(
                    @interface.Declarations,
                    declaration => new NestedInterfaceDeclarationWithSyntax(declaration));
            }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(@interface.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @interface.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @interface.IsGeneric; }
        }

        public string Name
        {
            get { return @interface.Name; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @interface.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedInterface(this);
        }
    }
}
