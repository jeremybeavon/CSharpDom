using System;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection.Internal
{
    internal class DocumentNodeWithReflection : DocumentNodeWithSymbols, IDocumentWithReflection
    {
        public DocumentNodeWithReflection(Document document, ProjectNode project)
            : base(document, project)
        {
        }

        public IDocumentWithSymbols Symbols
        {
            get { return this; }
        }

        IProjectWithReflection IHasProject<IProjectWithReflection>.Project
        {
            get { return (IProjectWithReflection)Project; }
        }

        ISolutionWithReflection IHasSolution<ISolutionWithReflection>.Solution
        {
            get { return (ISolutionWithReflection)Solution; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
