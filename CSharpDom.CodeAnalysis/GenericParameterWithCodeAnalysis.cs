using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly Node<GenericParameterWithCodeAnalysis, TypeSyntax> node;
        private readonly CachedChildNode<GenericParameterWithCodeAnalysis, TypeSyntax, ITypeReferenceWithCodeAnalysis> type;
        
        internal GenericParameterWithCodeAnalysis(ClassReferenceWithCodeAnalysis parent)
            : this()
        {
            ClassReferenceParent = parent;
        }

        internal GenericParameterWithCodeAnalysis(DelegateReferenceWithCodeAnalysis parent)
            : this()
        {
            DelegateReferenceParent = parent;
        }

        internal GenericParameterWithCodeAnalysis(InterfaceReferenceWithCodeAnalysis parent)
            : this()
        {
            InterfaceReferenceParent = parent;
        }

        private GenericParameterWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<GenericParameterWithCodeAnalysis, TypeSyntax>(this);
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        public TypeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal ClassReferenceWithCodeAnalysis ClassReferenceParent
        {
            get { return node.GetParentNode<ClassReferenceWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassReferenceWithCodeAnalysis, NameSyntax>(
                    value,
                    parent => parent.GenericParameterList);
            }
        }

        internal DelegateReferenceWithCodeAnalysis DelegateReferenceParent
        {
            get { return node.GetParentNode<DelegateReferenceWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<DelegateReferenceWithCodeAnalysis, NameSyntax>(
                    value,
                    parent => parent.GenericParameterList);
            }
        }

        internal InterfaceReferenceWithCodeAnalysis InterfaceReferenceParent
        {
            get { return node.GetParentNode<InterfaceReferenceWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<InterfaceReferenceWithCodeAnalysis, NameSyntax>(
                    value,
                    parent => parent.GenericParameterList);
            }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
