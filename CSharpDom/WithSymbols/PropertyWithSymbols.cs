﻿using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class PropertyWithSymbols : AbstractSymbolNode<IPropertyWithSymbols>
    {
        private readonly IPropertyWithSymbols property;

        public PropertyWithSymbols(IPropertyWithSymbols property)
            : base(property)
        {
            this.property = property;
        }

        public PropertyDeclarationSyntax Declaration
        {
            get { return property.Declaration; }
        }

        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(property.DeclaringType); }
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

        public override void Accept(SymbolsVisitor visitor)
        {
            property.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
