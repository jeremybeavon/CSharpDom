using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil
{
    public sealed class EnumReferenceWithMonoCecil :
        AbstractEnumReference,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;

        internal EnumReferenceWithMonoCecil(TypeReference type)
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
            visitor.VisitEnumReferenceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
