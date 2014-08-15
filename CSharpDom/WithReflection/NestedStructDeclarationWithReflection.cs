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
    public sealed class NestedStructDeclarationWithReflection : TypeWithReflection
    {
        private readonly INestedStructDeclarationWithReflection @struct;

        public NestedStructDeclarationWithReflection(INestedStructDeclarationWithReflection @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public NestedStructWithReflection CompositeType
        {
            get { return new NestedStructWithReflection(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public TypeWithReflection DeclaringType
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

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @struct.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
