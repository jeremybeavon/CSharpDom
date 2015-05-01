using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NestedStructWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly INestedStructWithLinqExpressions @struct;

        public NestedStructWithLinqExpressions(INestedStructWithLinqExpressions @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<NestedStructDeclarationWithLinqExpressions> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructDeclarationWithLinqExpressions, INestedStructDeclarationWithLinqExpressions>(
                    @struct.Declarations,
                    declaration => new NestedStructDeclarationWithLinqExpressions(declaration));
            }
        }

        public TypeWithLinqExpressions DeclaringType
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

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @struct.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
