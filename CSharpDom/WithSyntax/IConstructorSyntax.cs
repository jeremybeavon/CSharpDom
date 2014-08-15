using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IConstructorSyntax : IConstructor, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
