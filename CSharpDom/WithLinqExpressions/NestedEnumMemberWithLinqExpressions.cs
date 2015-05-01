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
    public sealed class NestedEnumMemberWithLinqExpressions
    {
        private readonly INestedEnumMemberWithLinqExpressions enumMember;

        public NestedEnumMemberWithLinqExpressions(INestedEnumMemberWithLinqExpressions enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public NestedEnumWithLinqExpressions DeclaringType
        {
            get { return new NestedEnumWithLinqExpressions(enumMember.DeclaringType); }
        }

        public int EndLine
        {
            get { return enumMember.EndLine; }
        }

        public string Name
        {
            get { return enumMember.Name; }
        }

        public int StartLine
        {
            get { return enumMember.StartLine; }
        }

        public IFieldSymbol Symbol
        {
            get { return enumMember.Symbol; }
        }

        public INestedEnumMemberWithLinqExpressions AsInterface()
        {
            return enumMember;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            enumMember.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return enumMember.ToString();
        }
    }
}
