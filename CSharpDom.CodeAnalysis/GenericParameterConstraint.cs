using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class GenericParameterConstraint : 
        IHasSyntax<TypeConstraintSyntax>,
        IHasNode<TypeConstraintSyntax>
    {
        private readonly Node<GenericParameterConstraint, TypeConstraintSyntax> node;
        private readonly CachedChildNode<
            GenericParameterConstraint,
            TypeConstraintSyntax,
            UnspecifiedTypeReferenceWithCodeAnalysis,
            NameSyntax> type;

        public GenericParameterConstraint()
        {
            node = new Node<GenericParameterConstraint, TypeConstraintSyntax>(this);
            type = new CachedChildNode<GenericParameterConstraint, TypeConstraintSyntax, UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(
                node,
                () => new UnspecifiedTypeReferenceWithCodeAnalysis(),
                syntax => (NameSyntax)syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public UnspecifiedTypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        public INode<TypeConstraintSyntax> Node => node;

        public TypeConstraintSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }
    }
}
