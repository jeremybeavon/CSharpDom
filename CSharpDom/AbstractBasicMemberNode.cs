using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class AbstractBasicMemberNode<TDeclaration> : AbstractNode<TDeclaration, IBasicMemberContainer>
        where TDeclaration : SyntaxNode
    {
        protected AbstractBasicMemberNode(TDeclaration declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        public IBasicCompositeType DeclaringType
        {
            get { return Container.BasicCompositeType; }
        }
    }
}
