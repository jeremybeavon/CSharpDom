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
    public sealed class EnumWithLinqExpressions
    {
        private readonly IEnumWithLinqExpressions @enum;

        public EnumWithLinqExpressions(IEnumWithLinqExpressions @enum)
        {
            this.@enum = @enum;
        }

        public EnumDeclarationSyntax Declaration
        {
            get { return @enum.Declaration; }
        }

        public int EndLine
        {
            get { return @enum.EndLine; }
        }

        public IReadOnlyCollection<EnumMemberWithLinqExpressions> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumMemberWithLinqExpressions, IEnumMemberWithLinqExpressions>(
                    @enum.EnumMembers,
                    enumMember => new EnumMemberWithLinqExpressions(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public NamespaceWithLinqExpressions Namespace
        {
            get { return new NamespaceWithLinqExpressions(@enum.Namespace); }
        }

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@enum.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@enum.Solution); }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @enum.Symbol; }
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
