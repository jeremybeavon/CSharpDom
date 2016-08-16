using System;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterReferenceWithCodeAnalysis :
        AbstractGenericParameterReference,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;

        internal GenericParameterReferenceWithCodeAnalysis(TypeReference type)
        {
            this.type = type;
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public TypeReference TypeReference
        {
            get { return type; }
        }


        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
