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
    public sealed class FieldWithSymbols : AbstractSymbolNode<IFieldWithSymbols>
    {
        private readonly IFieldWithSymbols field;

        public FieldWithSymbols(IFieldWithSymbols field)
            : base(field)
        {
            this.field = field;
        }

        public FieldDeclarationSyntax Declaration
        {
            get { return field.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(field.DeclaringType); }
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

        public IFieldWithSymbols AsInterface()
        {
            return field;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            field.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
