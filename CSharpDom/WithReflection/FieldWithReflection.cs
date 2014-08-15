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
    public sealed class FieldWithReflection
    {
        private readonly IFieldWithReflection field;

        public FieldWithReflection(IFieldWithReflection field)
        {
            this.field = field;
        }

        public FieldDeclarationSyntax Declaration
        {
            get { return field.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(field.DeclaringType); }
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

        public IFieldWithReflection AsInterface()
        {
            return field;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            field.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return field.ToString();
        }
    }
}
