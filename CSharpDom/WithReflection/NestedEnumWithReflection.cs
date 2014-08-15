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
    public sealed class NestedEnumWithReflection
    {
        private readonly INestedEnumWithReflection @enum;

        public NestedEnumWithReflection(INestedEnumWithReflection @enum)
        {
            this.@enum = @enum;
        }

        public EnumDeclarationSyntax Declaration
        {
            get { return @enum.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(@enum.DeclaringType); }
        }

        public int EndLine
        {
            get { return @enum.EndLine; }
        }

        public IReadOnlyCollection<NestedEnumMemberWithReflection> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumMemberWithReflection, INestedEnumMemberWithReflection>(
                    @enum.EnumMembers,
                    enumMember => new NestedEnumMemberWithReflection(enumMember));
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

        public INestedEnumWithReflection AsInterface()
        {
            return @enum;
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
