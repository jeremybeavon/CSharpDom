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
    public sealed class FieldWithLinqExpressions
    {
        private readonly IFieldWithLinqExpressions field;

        public FieldWithLinqExpressions(IFieldWithLinqExpressions field)
        {
            this.field = field;
        }

        public FieldDeclarationSyntax Declaration
        {
            get { return field.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(field.DeclaringType); }
        }

        public int EndLine
        {
            get { return field.EndLine; }
        }

        public string Name
        {
            get { return field.Name; }
        }

        public int StartLine
        {
            get { return field.StartLine; }
        }

        public IFieldSymbol Symbol
        {
            get { return field.Symbol; }
        }

        public IFieldWithLinqExpressions AsInterface()
        {
            return field;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            field.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return field.ToString();
        }
    }
}
