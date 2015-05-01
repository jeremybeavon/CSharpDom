using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class PropertyWithLinqExpressions
    {
        private readonly IPropertyWithLinqExpressions property;

        public PropertyWithLinqExpressions(IPropertyWithLinqExpressions property)
        {
            this.property = property;
        }

        public PropertyInfo PropertyInfo
        {
            get { return property.PropertyInfo; }
        }

        public PropertyDeclarationSyntax Declaration
        {
            get { return property.Declaration; }
        }

        public BasicTypeWithLinqExpressions DeclaringType
        {
            get { return BasicTypeWithLinqExpressions.GetBasicType(property.DeclaringType); }
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

        public void Accept(LinqExpressionsVisitor visitor)
        {
            property.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return property.ToString();
        }
    }
}
