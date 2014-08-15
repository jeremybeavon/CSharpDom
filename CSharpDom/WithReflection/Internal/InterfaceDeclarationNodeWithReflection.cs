using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class InterfaceDeclarationNodeWithReflection : InterfaceDeclarationNodeWithSymbols,
        IInterfaceDeclarationWithReflection,
        INestedInterfaceDeclarationWithReflection
    {
        private Type type;

        public InterfaceDeclarationNodeWithReflection(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container, 
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IInterfaceDeclarationWithSymbols Symbols
        {
            get { return this; }
        }

        public Type Type
        {
            get { return type ?? (type = BuildType()); }
        }

        INestedInterfaceWithReflection IHasCompositeType<INestedInterfaceWithReflection>.CompositeType
        {
            get { return (INestedInterfaceWithReflection)CompositeType; }
        }

        IInterfaceWithReflection IHasCompositeType<IInterfaceWithReflection>.CompositeType
        {
            get { return (IInterfaceWithReflection)CompositeType; }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        IDocumentWithReflection IHasDocument<IDocumentWithReflection>.Document
        {
            get { return (IDocumentWithReflection)Document; }
        }

        IReadOnlyCollection<IEventWithReflection> IHasEvents<IEventWithReflection>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithReflection, EventNode>(Events); }
        }

        IReadOnlyCollection<IIndexerWithReflection> IHasIndexers<IIndexerWithReflection>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithReflection, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<IMethodWithReflection> IHasMethods<IMethodWithReflection>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithReflection, MethodNode>(Methods); }
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

        INestedInterfaceDeclarationWithSymbols IHasSymbols<INestedInterfaceDeclarationWithSymbols>.Symbols
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
                ReflectionHelper.FindType(((IHasCompositeType<IInterfaceWithReflection>)this).CompositeType);
        }
    }
}
