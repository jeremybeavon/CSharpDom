using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class ClassNodeWithSyntax : ClassNode, IClassSyntax, INestedClassSyntax
    {
        public ClassNodeWithSyntax(ClassDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        IReadOnlyCollection<INestedClassSyntax> IHasClasses<INestedClassSyntax>.Classes
        {
            get { return new ReadOnlyNodeCollection<INestedClassSyntax, ClassNode>(Classes); }
        }

        IReadOnlyCollection<IConstructorSyntax> IHasConstructors<IConstructorSyntax>.Constructors
        {
            get { return new ReadOnlyNodeCollection<IConstructorSyntax, ConstructorNode>(Constructors); }
        }

        IReadOnlyCollection<IConversionOperatorSyntax> IHasConversionOperators<IConversionOperatorSyntax>.ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<IConversionOperatorSyntax, ConversionOperatorNode>(ConversionOperators);
            }
        }

        IReadOnlyCollection<INestedClassDeclarationSyntax> IHasDeclarations<INestedClassDeclarationSyntax>.Declarations
        {
            get { return new ReadOnlyNodeCollection<INestedClassDeclarationSyntax, ClassDeclarationNode>(Declarations); }
        }

        IReadOnlyCollection<IClassDeclarationSyntax> IHasDeclarations<IClassDeclarationSyntax>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IClassDeclarationSyntax, ClassDeclarationNode>(Declarations); }
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        IReadOnlyCollection<INestedDelegateSyntax> IHasDelegates<INestedDelegateSyntax>.Delegates
        {
            get { return new ReadOnlyNodeCollection<INestedDelegateSyntax, DelegateNode>(Delegates); }
        }

        INestedDestructorSyntax IHasDestructor<INestedDestructorSyntax>.Destructor
        {
            get { return (INestedDestructorSyntax)Destructor; }
        }

        IDestructorSyntax IHasDestructor<IDestructorSyntax>.Destructor
        {
            get { return (IDestructorSyntax)Destructor; }
        }

        IReadOnlyCollection<INestedEnumSyntax> IHasEnums<INestedEnumSyntax>.Enums
        {
            get { return new ReadOnlyNodeCollection<INestedEnumSyntax, EnumNode>(Enums); }
        }

        IReadOnlyCollection<IEventPropertySyntax> IHasEventProperties<IEventPropertySyntax>.EventProperties
        {
            get { return new ReadOnlyNodeCollection<IEventPropertySyntax, EventPropertyNode>(EventProperties); }
        }

        IReadOnlyCollection<IEventSyntax> IHasEvents<IEventSyntax>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventSyntax, EventNode>(Events); }
        }

        IReadOnlyCollection<IFieldSyntax> IHasFields<IFieldSyntax>.Fields
        {
            get { return new ReadOnlyNodeCollection<IFieldSyntax, FieldNode>(Fields); }
        }

        IReadOnlyCollection<IIndexerSyntax> IHasIndexers<IIndexerSyntax>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerSyntax, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<INestedInterfaceSyntax> IHasInterfaces<INestedInterfaceSyntax>.Interfaces
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceSyntax, InterfaceNode>(Interfaces); }
        }

        IReadOnlyCollection<IMethodSyntax> IHasMethods<IMethodSyntax>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodSyntax, MethodNode>(Methods); }
        }

        INamespaceSyntax IHasNamespace<INamespaceSyntax>.Namespace
        {
            get { return (INamespaceSyntax)Namespace; }
        }

        IReadOnlyCollection<IOperatorOverloadSyntax> IHasOperatorOverloads<IOperatorOverloadSyntax>.OperatorOverloads
        {
            get { return new ReadOnlyNodeCollection<IOperatorOverloadSyntax, OperatorOverloadNode>(OperatorOverloads); }
        }

        IProjectSyntax IHasProject<IProjectSyntax>.Project
        {
            get { return (IProjectSyntax)Project; }
        }

        IReadOnlyCollection<IPropertySyntax> IHasProperties<IPropertySyntax>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertySyntax, PropertyNode>(Properties); }
        }

        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }

        IReadOnlyCollection<INestedStructSyntax> IHasStructs<INestedStructSyntax>.Structs
        {
            get { return new ReadOnlyNodeCollection<INestedStructSyntax, StructNode>(Structs); }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return IsNestedType ? (AbstractSyntaxNode)new NestedClassWithSyntax(this) : new ClassWithSyntax(this);
        }
    }
}
