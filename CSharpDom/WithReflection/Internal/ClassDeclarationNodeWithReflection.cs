using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class ClassDeclarationNodeWithReflection : ClassDeclarationNodeWithSymbols,
        IClassDeclarationWithReflection,
        INestedClassDeclarationWithReflection
    {
        private Type type;

        public ClassDeclarationNodeWithReflection(
            ClassDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IClassDeclarationWithSymbols Symbols
        {
            get { return this; }
        }

        public Type Type
        {
            get { return type ?? (type = BuildType()); }
        }

        IReadOnlyCollection<INestedClassWithReflection> IHasClasses<INestedClassWithReflection>.Classes
        {
            get { return new ReadOnlyNodeCollection<INestedClassWithReflection, ClassNode>(Classes); }
        }

        INestedClassWithReflection IHasCompositeType<INestedClassWithReflection>.CompositeType
        {
            get { return (INestedClassWithReflection)CompositeType; }
        }

        IClassWithReflection IHasCompositeType<IClassWithReflection>.CompositeType
        {
            get { return (IClassWithReflection)CompositeType; }
        }

        IReadOnlyCollection<IConstructorWithReflection> IHasConstructors<IConstructorWithReflection>.Constructors
        {
            get { return new ReadOnlyNodeCollection<IConstructorWithReflection, ConstructorNode>(Constructors); }
        }

        IReadOnlyCollection<IConversionOperatorWithReflection> IHasConversionOperators<IConversionOperatorWithReflection>.ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<IConversionOperatorWithReflection, ConversionOperatorNode>(ConversionOperators);
            }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        IReadOnlyCollection<INestedDelegateWithReflection> IHasDelegates<INestedDelegateWithReflection>.Delegates
        {
            get { return new ReadOnlyNodeCollection<INestedDelegateWithReflection, DelegateNode>(Delegates); }
        }

        IDestructorWithReflection IHasDestructor<IDestructorWithReflection>.Destructor
        {
            get { return (IDestructorWithReflection)Destructor; }
        }

        IDocumentWithReflection IHasDocument<IDocumentWithReflection>.Document
        {
            get { return (IDocumentWithReflection)Container; }
        }

        IReadOnlyCollection<INestedEnumWithReflection> IHasEnums<INestedEnumWithReflection>.Enums
        {
            get { return new ReadOnlyNodeCollection<INestedEnumWithReflection, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IEventPropertyWithReflection> IHasEventProperties<IEventPropertyWithReflection>.EventProperties
        {
            get { return new ReadOnlyNodeCollection<IEventPropertyWithReflection, EventPropertyNode>(EventProperties); }
        }

        IReadOnlyCollection<IEventWithReflection> IHasEvents<IEventWithReflection>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithReflection, EventNode>(Events); }
        }

        IReadOnlyCollection<IFieldWithReflection> IHasFields<IFieldWithReflection>.Fields
        {
            get { return new ReadOnlyNodeCollection<IFieldWithReflection, FieldNode>(Fields); }
        }

        IReadOnlyCollection<IIndexerWithReflection> IHasIndexers<IIndexerWithReflection>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithReflection, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<INestedInterfaceWithReflection> IHasInterfaces<INestedInterfaceWithReflection>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceWithReflection, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IMethodWithReflection> IHasMethods<IMethodWithReflection>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithReflection, MethodNode>(Methods); }
        }

        IReadOnlyCollection<IOperatorOverloadWithReflection> IHasOperatorOverloads<IOperatorOverloadWithReflection>.OperatorOverloads
        {
            get { return new ReadOnlyNodeCollection<IOperatorOverloadWithReflection, OperatorOverloadNode>(OperatorOverloads); }
        }

        IProjectWithReflection IHasProject<IProjectWithReflection>.Project
        {
            get { return (IProjectWithReflection)Project; }
        }

        IReadOnlyCollection<IPropertyWithReflection> IHasProperties<IPropertyWithReflection>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithReflection, PropertyNode>(Properties); }
        }

        ISolutionWithReflection IHasSolution<ISolutionWithReflection>.Solution
        {
            get { return (ISolutionWithReflection)Solution; }
        }

        IReadOnlyCollection<INestedStructWithReflection> IHasStructs<INestedStructWithReflection>.Structs
        {
            get { return new ReadOnlyNodeCollection<INestedStructWithReflection, StructNode>(Structs); }
        }

        INestedClassDeclarationWithSymbols IHasSymbols<INestedClassDeclarationWithSymbols>.Symbols
        {
            get { return this; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }

        private Type BuildType()
        {
            return IsNestedType ?
                ReflectionHelper.FindNestedType(this) :
                ReflectionHelper.FindType(((IHasCompositeType<IClassWithReflection>)this).CompositeType);
        }
    }
}
