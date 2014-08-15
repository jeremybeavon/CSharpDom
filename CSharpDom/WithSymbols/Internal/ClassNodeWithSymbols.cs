using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class ClassNodeWithSymbols : ClassNodeWithSyntax, IClassWithSymbols, INestedClassWithSymbols
    {
        public ClassNodeWithSymbols(ClassDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public INamedTypeSymbol Symbol
        {
            get { return ((IHasSymbol<INamedTypeSymbol>)Declarations[0]).Symbol; }
        }

        public IClassSyntax Syntax
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

        IReadOnlyCollection<INestedClassDeclarationWithSymbols> IHasDeclarations<INestedClassDeclarationWithSymbols>.Declarations
        {
            get { return new ReadOnlyNodeCollection<INestedClassDeclarationWithSymbols, ClassDeclarationNode>(Declarations); }
        }

        IReadOnlyCollection<IClassDeclarationWithSymbols> IHasDeclarations<IClassDeclarationWithSymbols>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IClassDeclarationWithSymbols, ClassDeclarationNode>(Declarations); }
        }

        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        IReadOnlyCollection<INestedDelegateWithSymbols> IHasDelegates<INestedDelegateWithSymbols>.Delegates
        {
            get { return new ReadOnlyNodeCollection<INestedDelegateWithSymbols, DelegateNode>(Delegates); }
        }

        INestedDestructorWithSymbols IHasDestructor<INestedDestructorWithSymbols>.Destructor
        {
            get { return (INestedDestructorWithSymbols)Destructor; }
        }

        IDestructorWithSymbols IHasDestructor<IDestructorWithSymbols>.Destructor
        {
            get { return (IDestructorWithSymbols)Destructor; }
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
            get { return (INamespaceWithSymbols)Namespace; }
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

        INestedClassSyntax IHasSyntax<INestedClassSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
