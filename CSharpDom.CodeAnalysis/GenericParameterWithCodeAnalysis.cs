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
        private readonly ChildNode<GenericParameterWithCodeAnalysis, TypeSyntax> node;
        private readonly CachedChildNode<GenericParameterWithCodeAnalysis, ITypeReferenceWithCodeAnalysis, TypeSyntax> type;
        
        //public GenericParameterWithCodeAnalysis(TypeReferenceWithCodeAnalysis typeReference)
        //    : this(new DetachedParentWithId<GenericParameterWithCodeAnalysis, TypeSyntax>(typeReference.Syntax))
        //{
        //}

        internal GenericParameterWithCodeAnalysis(ClassReferenceWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new ChildNode<GenericParameterWithCodeAnalysis, TypeSyntax>(this);
            //type = new CachedChildNode<GenericParameterWithCodeAnalysis, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
            //    this,
            //    node,
            //    syntax => null,
            //    (syntax, value) => null,
            //    (value, newParent) => { });
            ClassReferenceParent = parent;
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
                    () => value.GenericParameterList);
            }
        }

        private void RefreshType()
        {
            TypeSyntax syntax = node.Syntax;
            ITypeReferenceWithCodeAnalysis typeReference = base.Type;
            ArrayTypeSyntax arrayType = syntax as ArrayTypeSyntax;
            if (arrayType != null)
            {
                if (!(typeReference is ArrayTypeReferenceWithCodeAnalysis))
                {
                    base.Type = new ArrayTypeReferenceWithCodeAnalysis(this);
                }

                return;
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
