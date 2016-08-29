using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceReferenceWithCodeAnalysis :
        EditableInterfaceReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;

        internal InterfaceReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
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
