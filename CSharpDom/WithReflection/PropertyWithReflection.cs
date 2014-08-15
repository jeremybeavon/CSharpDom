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
    public sealed class PropertyWithReflection
    {
        private readonly IPropertyWithReflection property;

        public PropertyWithReflection(IPropertyWithReflection property)
        {
            this.property = property;
        }

        public PropertyDeclarationSyntax Declaration
        {
            get { return property.Declaration; }
        }

        public BasicTypeWithReflection DeclaringType
        {
            get { return BasicTypeWithReflection.GetBasicType(property.DeclaringType); }
        }

        public int EndLine
        {
            get { return property.EndLine; }
        }

        public bool HasGet
        {
            get { return property.HasGet; }
        }

        public bool HasSet
        {
            get { return property.HasSet; }
        }

        public string Name
        {
            get { return property.Name; }
        }

        public int StartLine
        {
            get { return property.StartLine; }
        }

        public IPropertySymbol Symbol
        {
            get { return property.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            property.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return property.ToString();
        }
    }
}
