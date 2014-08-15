using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedClassDeclarationWithSymbols : TypeWithSymbols
    {
        private readonly INestedClassDeclarationWithSymbols @class;

        public NestedClassDeclarationWithSymbols(INestedClassDeclarationWithSymbols @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public NestedClassWithSymbols CompositeType
        {
            get { return new NestedClassWithSymbols(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(@class.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public INestedClassDeclarationWithSymbols AsInterface()
        {
            return @class;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @class.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
