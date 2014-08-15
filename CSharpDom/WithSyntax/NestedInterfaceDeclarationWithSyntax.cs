using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedInterfaceDeclarationWithSyntax : BasicTypeWithSyntax
    {
        private readonly INestedInterfaceDeclarationSyntax @interface;

        public NestedInterfaceDeclarationWithSyntax(INestedInterfaceDeclarationSyntax @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public NestedInterfaceWithSyntax CompositeType
        {
            get { return new NestedInterfaceWithSyntax(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(@interface.DeclaringType); }
        }

        public int EndLine
        {
            get { return @interface.EndLine; }
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

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public INestedInterfaceDeclarationSyntax AsInterface()
        {
            return @interface;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @interface.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedInterfaceDeclaration(this);
        }
    }
}
