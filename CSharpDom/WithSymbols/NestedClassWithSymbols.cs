using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedClassWithSymbols : TypeWithSymbols
    {
        private readonly INestedClassWithSymbols @class;

        public NestedClassWithSymbols(INestedClassWithSymbols @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<NestedClassDeclarationWithSymbols> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassDeclarationWithSymbols, INestedClassDeclarationWithSymbols>(
                    @class.Declarations,
                    declaration => new NestedClassDeclarationWithSymbols(declaration));
            }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return GetType(@class.DeclaringType); }
        }

        public NestedDestructorWithSymbols Destructor
        {
            get { return @class.Destructor == null ? null : new NestedDestructorWithSymbols(@class.Destructor); }
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

        public INestedClassWithSymbols AsInterface()
        {
            return @class;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @class.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
