using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class ClassDeclarationNodeWithLinqExpressions : ClassDeclarationNodeWithReflection,
        IClassDeclarationWithLinqExpressions,
        INestedClassDeclarationWithLinqExpressions
    {
        public ClassDeclarationNodeWithLinqExpressions(
            ClassDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IClassDeclarationWithReflection Reflection
        {
            get { return this; }
        }

        IReadOnlyCollection<INestedClassWithLinqExpressions> IHasClasses<INestedClassWithLinqExpressions>.Classes
        {
            get { return new ReadOnlyNodeCollection<INestedClassWithLinqExpressions, ClassNode>(Classes); }
        }

        INestedClassWithLinqExpressions IHasCompositeType<INestedClassWithLinqExpressions>.CompositeType
        {
            get { return (INestedClassWithLinqExpressions)CompositeType; }
        }

        IClassWithLinqExpressions IHasCompositeType<IClassWithLinqExpressions>.CompositeType
        {
            get { return (IClassWithLinqExpressions)CompositeType; }
        }

        IReadOnlyCollection<IConstructorWithLinqExpressions> IHasConstructors<IConstructorWithLinqExpressions>.Constructors
        {
            get { return new ReadOnlyNodeCollection<IConstructorWithLinqExpressions, ConstructorNode>(Constructors); }
        }

        IReadOnlyCollection<IConversionOperatorWithLinqExpressions> IHasConversionOperators<IConversionOperatorWithLinqExpressions>.ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<IConversionOperatorWithLinqExpressions, ConversionOperatorNode>(ConversionOperators);
            }
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }

        IReadOnlyCollection<INestedDelegateWithLinqExpressions> IHasDelegates<INestedDelegateWithLinqExpressions>.Delegates
        {
            get { return new ReadOnlyNodeCollection<INestedDelegateWithLinqExpressions, DelegateNode>(Delegates); }
        }

        IDestructorWithLinqExpressions IHasDestructor<IDestructorWithLinqExpressions>.Destructor
        {
            get { return (IDestructorWithLinqExpressions)Destructor; }
        }

        IDocumentWithLinqExpressions IHasDocument<IDocumentWithLinqExpressions>.Document
        {
            get { return (IDocumentWithLinqExpressions)Container; }
        }

        IReadOnlyCollection<INestedEnumWithLinqExpressions> IHasEnums<INestedEnumWithLinqExpressions>.Enums
        {
            get { return new ReadOnlyNodeCollection<INestedEnumWithLinqExpressions, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IEventPropertyWithLinqExpressions> IHasEventProperties<IEventPropertyWithLinqExpressions>.EventProperties
        {
            get { return new ReadOnlyNodeCollection<IEventPropertyWithLinqExpressions, EventPropertyNode>(EventProperties); }
        }

        IReadOnlyCollection<IEventWithLinqExpressions> IHasEvents<IEventWithLinqExpressions>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithLinqExpressions, EventNode>(Events); }
        }

        IReadOnlyCollection<IFieldWithLinqExpressions> IHasFields<IFieldWithLinqExpressions>.Fields
        {
            get { return new ReadOnlyNodeCollection<IFieldWithLinqExpressions, FieldNode>(Fields); }
        }

        IReadOnlyCollection<IIndexerWithLinqExpressions> IHasIndexers<IIndexerWithLinqExpressions>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithLinqExpressions, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<INestedInterfaceWithLinqExpressions> IHasInterfaces<INestedInterfaceWithLinqExpressions>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceWithLinqExpressions, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IMethodWithLinqExpressions> IHasMethods<IMethodWithLinqExpressions>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithLinqExpressions, MethodNode>(Methods); }
        }

        IReadOnlyCollection<IOperatorOverloadWithLinqExpressions> IHasOperatorOverloads<IOperatorOverloadWithLinqExpressions>.OperatorOverloads
        {
            get { return new ReadOnlyNodeCollection<IOperatorOverloadWithLinqExpressions, OperatorOverloadNode>(OperatorOverloads); }
        }

        IProjectWithLinqExpressions IHasProject<IProjectWithLinqExpressions>.Project
        {
            get { return (IProjectWithLinqExpressions)Project; }
        }

        IReadOnlyCollection<IPropertyWithLinqExpressions> IHasProperties<IPropertyWithLinqExpressions>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithLinqExpressions, PropertyNode>(Properties); }
        }

        INestedClassDeclarationWithReflection IHasReflection<INestedClassDeclarationWithReflection>.Reflection
        {
            get { return this; }
        }

        ISolutionWithLinqExpressions IHasSolution<ISolutionWithLinqExpressions>.Solution
        {
            get { return (ISolutionWithLinqExpressions)Solution; }
        }

        IReadOnlyCollection<INestedStructWithLinqExpressions> IHasStructs<INestedStructWithLinqExpressions>.Structs
        {
            get { return new ReadOnlyNodeCollection<INestedStructWithLinqExpressions, StructNode>(Structs); }
        }
    }
}
