using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnspecifiedTypeReferenceWithCodeAnalysis :
        EditableUnspecifiedTypeReference<GenericParameterWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis,
        IHasId//,
                                      //IVisitable<IReflectionVisitor>
    {
        private readonly Node<UnspecifiedTypeReferenceWithCodeAnalysis, TypeSyntax> node;

        public TypeSyntax Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
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
            visitor.VisitUnspecifiedTypeReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
