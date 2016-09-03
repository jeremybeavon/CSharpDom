using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateReferenceWithCodeAnalysis :
        EditableDelegateReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;

        internal DelegateReferenceWithCodeAnalysis(EventPropertyWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent, false))
        {
        }

        internal DelegateReferenceWithCodeAnalysis(EventWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent))
        {
        }

        internal DelegateReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }
        
        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return typeReference.GenericParameters; }
            set { typeReference.GenericParameters = value; }
        }

        public override string Name
        {
            get { return typeReference.Name; }
            set { typeReference.Name = value; }
        }
        
        public NameSyntax Syntax
        {
            get { return typeReference.Syntax; }
            set { typeReference.Syntax = value; }
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis TypeReference
        {
            get { return typeReference; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDelegateReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
