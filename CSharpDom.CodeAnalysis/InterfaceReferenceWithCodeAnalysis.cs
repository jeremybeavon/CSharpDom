using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceReferenceWithCodeAnalysis :
        EditableInterfaceReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IHasId//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;

        internal InterfaceReferenceWithCodeAnalysis(EventPropertyWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent, true))
        { 
        }

        internal InterfaceReferenceWithCodeAnalysis(IndexerWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent))
        {
        }

        internal InterfaceReferenceWithCodeAnalysis(MethodWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent))
        {
        }

        internal InterfaceReferenceWithCodeAnalysis(PropertyWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent))
        {
        }

        private InterfaceReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
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

        Guid IHasId.InternalId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
