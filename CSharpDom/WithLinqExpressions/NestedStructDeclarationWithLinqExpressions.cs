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
    public sealed class NestedStructDeclarationWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly INestedStructDeclarationWithLinqExpressions @struct;

        public NestedStructDeclarationWithLinqExpressions(INestedStructDeclarationWithLinqExpressions @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public NestedStructWithLinqExpressions CompositeType
        {
            get { return new NestedStructWithLinqExpressions(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
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
