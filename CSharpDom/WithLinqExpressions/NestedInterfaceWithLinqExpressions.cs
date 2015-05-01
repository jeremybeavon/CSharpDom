using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NestedInterfaceWithLinqExpressions : BasicTypeWithLinqExpressions
    {
        private readonly INestedInterfaceWithLinqExpressions @interface;

        public NestedInterfaceWithLinqExpressions(INestedInterfaceWithLinqExpressions @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<NestedInterfaceDeclarationWithLinqExpressions> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceDeclarationWithLinqExpressions, INestedInterfaceDeclarationWithLinqExpressions>(
                    @interface.Declarations,
                    declaration => new NestedInterfaceDeclarationWithLinqExpressions(declaration));
            }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(@interface.DeclaringType); }
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

        public INamedTypeSymbol Symbol
        {
            get { return @interface.Symbol; }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @interface.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @interface.ToString();
        }
    }
}
