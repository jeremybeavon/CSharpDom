using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NestedClassWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly INestedClassWithLinqExpressions @class;

        public NestedClassWithLinqExpressions(INestedClassWithLinqExpressions @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<NestedClassDeclarationWithLinqExpressions> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassDeclarationWithLinqExpressions, INestedClassDeclarationWithLinqExpressions>(
                    @class.Declarations,
                    declaration => new NestedClassDeclarationWithLinqExpressions(declaration));
            }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return GetType(@class.DeclaringType); }
        }

        public NestedDestructorWithLinqExpressions Destructor
        {
            get { return @class.Destructor == null ? null : new NestedDestructorWithLinqExpressions(@class.Destructor); }
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

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public INestedClassWithLinqExpressions AsInterface()
        {
            return @class;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @class.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @class.ToString();
        }
    }
}
