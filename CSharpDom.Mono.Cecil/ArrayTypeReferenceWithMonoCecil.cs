using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ArrayTypeReferenceWithMonoCecil :
        AbstractArrayTypeReference<ITypeReferenceWithMonoCecil>,
        ITypeReferenceWithMonoCecil,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Type type;
        private readonly int dimensions;
        private readonly ITypeReferenceWithMonoCecil elementType;

        internal ArrayTypeReferenceWithMonoCecil(Type type)
        {
            this.type = type;
            dimensions = type.GetArrayRank();
            elementType = TypeReferenceWithMonoCecilFactory.CreateReference(type.GetElementType());
        }

        public override int Dimensions
        {
            get { return dimensions; }
        }

        public override ITypeReferenceWithMonoCecil ElementType
        {
            get { return elementType; }
        }

        public Type Type
        {
            get { return type; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitArrayTypeReferenceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
