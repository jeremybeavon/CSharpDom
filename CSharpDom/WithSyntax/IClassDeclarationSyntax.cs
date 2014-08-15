using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface IClassDeclarationSyntax : IClass, IHasLocation,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<IClassSyntax>,
        IHasDocument<IDocumentSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        ITypeSyntax,
        IHasDestructor<IDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
