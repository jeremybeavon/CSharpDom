using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class ClassNodeWithLinqExpressions : ClassNodeWithReflection, IClassWithLinqExpressions,
        INestedClassWithLinqExpressions
    {
        public ClassNodeWithLinqExpressions(ClassDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public IClassWithReflection Reflection
        {
            get { return this; }
        }

        IReadOnlyCollection<INestedClassWithLinqExpressions> IHasClasses<INestedClassWithLinqExpressions>.Classes
        {
            get { return new ReadOnlyNodeCollection<INestedClassWithLinqExpressions, ClassNode>(Classes); }
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

        IReadOnlyCollection<IClassDeclarationWithLinqExpressions> IHasDeclarations<IClassDeclarationWithLinqExpressions>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IClassDeclarationWithLinqExpressions, ClassDeclarationNode>(Declarations); }
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

        INamespaceWithLinqExpressions IHasNamespace<INamespaceWithLinqExpressions>.Namespace
        {
            get { return (INamespaceWithLinqExpressions)Namespace; }
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

        INestedClassWithReflection IHasReflection<INestedClassWithReflection>.Reflection
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
