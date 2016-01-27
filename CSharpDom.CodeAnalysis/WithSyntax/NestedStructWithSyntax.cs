using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class NestedStructWithSyntax : TypeWithSyntax
    {
        private readonly INestedStructSyntax @struct;

        public NestedStructWithSyntax(INestedStructSyntax @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<NestedStructDeclarationWithSyntax> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructDeclarationWithSyntax, INestedStructDeclarationSyntax>(
                    @struct.Declarations,
                    declaration => new NestedStructDeclarationWithSyntax(declaration));
            }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return GetType(@struct.DeclaringType); }
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

        public override void Accept(SyntaxVisitor visitor)
        {
            @struct.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedStruct(this);
        }
    }
}
