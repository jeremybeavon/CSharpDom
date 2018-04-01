using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class GenericParameterList<TParent, TParentSyntax> :
        WrappedList<IInternalTypeReferenceWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly GenericParameterNodeList<TParent, TParentSyntax> list;

        public GenericParameterList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, NameSyntax> getSyntax,
            Func<TParentSyntax, NameSyntax, TParentSyntax> setSyntax)
            : this(new GenericParameterNodeList<TParent, TParentSyntax>(node, getSyntax, setSyntax))
        {
        }

        private GenericParameterList(
            GenericParameterNodeList<TParent, TParentSyntax> list)
            : base(
                  list,
                  parent => parent,
                  child => (IInternalTypeReferenceWithCodeAnalysis)child)
        {
            this.list = list;
        }

        public void ReplaceList(IEnumerable<ITypeReferenceWithCodeAnalysis> newList)
        {
            list.ReplaceList(newList.Cast<IInternalTypeReferenceWithCodeAnalysis>());
        }
    }
}
