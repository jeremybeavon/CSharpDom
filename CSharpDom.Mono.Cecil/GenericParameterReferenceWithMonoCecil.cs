using System;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class GenericParameterReferenceWithMonoCecil :
        AbstractGenericParameterReference,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;

        internal GenericParameterReferenceWithMonoCecil(TypeReference type)
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
            visitor.VisitGenericParameterReferenceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
