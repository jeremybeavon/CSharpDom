using System;
using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class StructNodeWithSymbols : StructNodeWithSyntax, IStructWithSymbols, INestedStructWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private INamedTypeSymbol symbol;

        public StructNodeWithSymbols(StructDeclarationSyntax declaration, ITypeContainer container, SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public INamedTypeSymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declarations[0].Declaration)); }
        }

        public IStructSyntax Syntax
        {
            get { return this; }
        }

        IReadOnlyCollection<INestedClassWithSymbols> IHasClasses<INestedClassWithSymbols>.Classes
        {
            get { return new ReadOnlyNodeCollection<INestedClassWithSymbols, ClassNode>(Classes); }
        }

        IReadOnlyCollection<IConstructorWithSymbols> IHasConstructors<IConstructorWithSymbols>.Constructors
        {
            get { return new ReadOnlyNodeCollection<IConstructorWithSymbols, ConstructorNode>(Constructors); }
        }

        IReadOnlyCollection<IConversionOperatorWithSymbols> IHasConversionOperators<IConversionOperatorWithSymbols>.ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<IConversionOperatorWithSymbols, ConversionOperatorNode>(ConversionOperators);
            }
        }

        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        IReadOnlyCollection<INestedDelegateWithSymbols> IHasDelegates<INestedDelegateWithSymbols>.Delegates
        {
            get { return new ReadOnlyNodeCollection<INestedDelegateWithSymbols, DelegateNode>(Delegates); }
        }

        IReadOnlyCollection<INestedEnumWithSymbols> IHasEnums<INestedEnumWithSymbols>.Enums
        {
            get { return new ReadOnlyNodeCollection<INestedEnumWithSymbols, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IEventPropertyWithSymbols> IHasEventProperties<IEventPropertyWithSymbols>.EventProperties
        {
            get { return new ReadOnlyNodeCollection<IEventPropertyWithSymbols, EventPropertyNode>(EventProperties); }
        }

        IReadOnlyCollection<IEventWithSymbols> IHasEvents<IEventWithSymbols>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithSymbols, EventNode>(Events); }
        }

        IReadOnlyCollection<IFieldWithSymbols> IHasFields<IFieldWithSymbols>.Fields
        {
            get { return new ReadOnlyNodeCollection<IFieldWithSymbols, FieldNode>(Fields); }
        }

        IReadOnlyCollection<IIndexerWithSymbols> IHasIndexers<IIndexerWithSymbols>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithSymbols, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<INestedInterfaceWithSymbols> IHasInterfaces<INestedInterfaceWithSymbols>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceWithSymbols, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IMethodWithSymbols> IHasMethods<IMethodWithSymbols>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithSymbols, MethodNode>(Methods); }
        }

        INamespaceWithSymbols IHasNamespace<INamespaceWithSymbols>.Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IReadOnlyCollection<IOperatorOverloadWithSymbols> IHasOperatorOverloads<IOperatorOverloadWithSymbols>.OperatorOverloads
        {
            get { return new ReadOnlyNodeCollection<IOperatorOverloadWithSymbols, OperatorOverloadNode>(OperatorOverloads); }
        }

        IProjectWithSymbols IHasProject<IProjectWithSymbols>.Project
        {
            get { return (IProjectWithSymbols)Project; }
        }

        IReadOnlyCollection<IPropertyWithSymbols> IHasProperties<IPropertyWithSymbols>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithSymbols, PropertyNode>(Properties); }
        }

        ISolutionWithSymbols IHasSolution<ISolutionWithSymbols>.Solution
        {
            get { return (ISolutionWithSymbols)Solution; }
        }

        IReadOnlyCollection<INestedStructWithSymbols> IHasStructs<INestedStructWithSymbols>.Structs
        {
            get { return new ReadOnlyNodeCollection<INestedStructWithSymbols, StructNode>(Structs); }
        }

        INestedStructSyntax IHasSyntax<INestedStructSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
