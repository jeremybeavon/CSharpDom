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
    public sealed class NestedEnumMemberWithReflection
    {
        private readonly INestedEnumMemberWithReflection enumMember;

        public NestedEnumMemberWithReflection(INestedEnumMemberWithReflection enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public NestedEnumWithReflection DeclaringType
        {
            get { return new NestedEnumWithReflection(enumMember.DeclaringType); }
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

        public INestedEnumMemberWithReflection AsInterface()
        {
            return enumMember;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            enumMember.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return enumMember.ToString();
        }
    }
}
