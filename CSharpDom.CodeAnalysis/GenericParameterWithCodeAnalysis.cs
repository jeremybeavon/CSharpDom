using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter<TypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private object parent;
        private Func<TypeSyntax> getType;
        private Action<TypeSyntax> setType;

        //public GenericParameterWithCodeAnalysis(TypeReferenceWithCodeAnalysis typeReference)
        //    : this(new DetachedParentWithId<GenericParameterWithCodeAnalysis, TypeSyntax>(typeReference.Syntax))
        //{
        //}

        internal GenericParameterWithCodeAnalysis(ClassReferenceWithCodeAnalysis parent)
        {
            ClassReferenceParent = parent;
        }
        
        public TypeSyntax Syntax
        {
            get { return getType(); }
            internal set { setType(value); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal ClassReferenceWithCodeAnalysis ClassReferenceParent
        {
            get { return parent as ClassReferenceWithCodeAnalysis; }
            set
            {
                parent = value;
                getType = () => ClassReferenceParent.GenericParameterList.GetChild(this);
                setType = list => ClassReferenceParent.GenericParameterList.SetChild(this, list);
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
