using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedClassSyntax : IClass, ITypeSyntax, IHasDeclaringType<ITypeSyntax>,
        IHasDeclarations<INestedClassDeclarationSyntax>,
        IHasDestructor<INestedDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
