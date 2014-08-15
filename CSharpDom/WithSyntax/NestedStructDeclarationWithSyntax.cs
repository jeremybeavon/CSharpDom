using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedStructDeclarationWithSyntax : TypeWithSyntax
    {
        private readonly INestedStructDeclarationSyntax @struct;

        public NestedStructDeclarationWithSyntax(INestedStructDeclarationSyntax @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public NestedStructWithSyntax CompositeType
        {
            get { return new NestedStructWithSyntax(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return GetType(@struct.DeclaringType); }
        }

        public int EndLine
        {
            get { return @struct.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @struct.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @struct.IsGeneric; }
        }

        public string Name
        {
            get { return @struct.Name; }
        }

        public int StartLine
        {
            get { return @struct.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @struct.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedStructDeclaration(this);
        }
    }
}
