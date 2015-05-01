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
    public sealed class NestedEnumWithLinqExpressions
    {
        private readonly INestedEnumWithLinqExpressions @enum;

        public NestedEnumWithLinqExpressions(INestedEnumWithLinqExpressions @enum)
        {
            this.@enum = @enum;
        }

        public EnumDeclarationSyntax Declaration
        {
            get { return @enum.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(@enum.DeclaringType); }
        }

        public int EndLine
        {
            get { return @enum.EndLine; }
        }

        public IReadOnlyCollection<NestedEnumMemberWithLinqExpressions> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumMemberWithLinqExpressions, INestedEnumMemberWithLinqExpressions>(
                    @enum.EnumMembers,
                    enumMember => new NestedEnumMemberWithLinqExpressions(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @enum.Symbol; }
        }

        public INestedEnumWithLinqExpressions AsInterface()
        {
            return @enum;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @enum.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @enum.ToString();
        }
    }
}
