using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EnumReferenceWithCodeAnalysis :
        EditableEnumReference,
        IHasSyntax<NameSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;

        internal EnumReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
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
            visitor.VisitEnumReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
