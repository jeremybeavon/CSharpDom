using System.Collections.Generic;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NamespaceWithSymbols : AbstractSymbolNode<INamespaceWithSymbols>
    {
        private readonly INamespaceWithSymbols @namespace;

        public NamespaceWithSymbols(INamespaceWithSymbols @namespace)
            : base(@namespace)
        {
            this.@namespace = @namespace;
        }

        public IReadOnlyCollection<ClassWithSymbols> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassWithSymbols, IClassWithSymbols>(
                    @namespace.Classes,
                    @class => new ClassWithSymbols(@class));
            }
        }

        public IEnumerable<NamespaceDeclarationSyntax> Declarations
        {
            get { return @namespace.Declarations; }
        }

        public IReadOnlyCollection<DelegateWithSymbols> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<DelegateWithSymbols, IDelegateWithSymbols>(
                    @namespace.Delegates,
                    @delegate => new DelegateWithSymbols(@delegate));
            }
        }

        public IReadOnlyCollection<EnumWithSymbols> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumWithSymbols, IEnumWithSymbols>(
                    @namespace.Enums,
                    @enum => new EnumWithSymbols(@enum));
            }
        }

        public IReadOnlyCollection<InterfaceWithSymbols> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceWithSymbols, IInterfaceWithSymbols>(
                    @namespace.Interfaces,
                    @interface => new InterfaceWithSymbols(@interface));
            }
        }

        public string Name
        {
            get { return @namespace.Name; }
        }

        public IReadOnlyCollection<StructWithSymbols> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<StructWithSymbols, IStructWithSymbols>(
                    @namespace.Structs,
                    @struct => new StructWithSymbols(@struct));
            }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @namespace.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
