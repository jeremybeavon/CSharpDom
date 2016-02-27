using System;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class GenericParameterReferenceWithMonoCecil :
        AbstractGenericParameterReference,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Type type;

        internal GenericParameterReferenceWithMonoCecil(Type type)
        {
            this.type = type;
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public Type Type
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
