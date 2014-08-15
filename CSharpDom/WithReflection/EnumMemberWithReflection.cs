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
    public sealed class EnumMemberWithReflection
    {
        private readonly IEnumMemberWithReflection enumMember;

        public EnumMemberWithReflection(IEnumMemberWithReflection enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public EnumWithReflection DeclaringType
        {
            get { return new EnumWithReflection(enumMember.DeclaringType); }
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
