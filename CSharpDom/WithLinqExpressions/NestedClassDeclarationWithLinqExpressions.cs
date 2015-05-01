using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NestedClassDeclarationWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly INestedClassDeclarationWithLinqExpressions @class;

        public NestedClassDeclarationWithLinqExpressions(INestedClassDeclarationWithLinqExpressions @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public NestedClassWithLinqExpressions CompositeType
        {
            get { return new NestedClassWithLinqExpressions(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(@class.DeclaringType); }
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

        public INestedClassDeclarationWithLinqExpressions AsInterface()
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
