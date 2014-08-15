using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class EnumWithReflection
    {
        private readonly IEnumWithReflection @enum;

        public EnumWithReflection(IEnumWithReflection @enum)
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

        public IReadOnlyCollection<EnumMemberWithReflection> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumMemberWithReflection, IEnumMemberWithReflection>(
                    @enum.EnumMembers,
                    enumMember => new EnumMemberWithReflection(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public NamespaceWithReflection Namespace
        {
            get { return new NamespaceWithReflection(@enum.Namespace); }
        }

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@enum.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@enum.Solution); }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @enum.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @enum.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @enum.ToString();
        }
    }
}
