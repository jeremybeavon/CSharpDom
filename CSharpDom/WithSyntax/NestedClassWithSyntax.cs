using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedClassWithSyntax : TypeWithSyntax
    {
        private readonly INestedClassSyntax @class;

        public NestedClassWithSyntax(INestedClassSyntax @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<NestedClassDeclarationWithSyntax> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassDeclarationWithSyntax, INestedClassDeclarationSyntax>(
                    @class.Declarations,
                    declaration => new NestedClassDeclarationWithSyntax(declaration));
            }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return GetType(@class.DeclaringType); }
        }

        public NestedDestructorWithSyntax Destructor
        {
            get { return @class.Destructor == null ? null : new NestedDestructorWithSyntax(@class.Destructor); }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public INestedClassSyntax AsInterface()
        {
            return @class;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @class.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedClass(this);
        }
    }
}
