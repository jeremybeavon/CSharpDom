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
    internal abstract class AbstractMemberNode<TDeclaration> : AbstractNode<TDeclaration, IMemberContainer>
        where TDeclaration : SyntaxNode
    {
        protected AbstractMemberNode(TDeclaration declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        public ICompositeType DeclaringType
        {
            get { return Container.CompositeType; }
        }
    }
}
