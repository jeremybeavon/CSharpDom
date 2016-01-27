using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;

namespace CSharpDom.Reflection
{
    public sealed class ArrayTypeReferenceWithReflection :
        AbstractArrayTypeReference<ITypeReferenceWithReflection>,
        ITypeReferenceWithReflection,
        IHasType,
        IVisitable<IReflectionVisitor>
    {
        private readonly Type type;
        private readonly int dimensions;
        private readonly ITypeReferenceWithReflection elementType;

        internal ArrayTypeReferenceWithReflection(Type type)
        {
            this.type = type;
            dimensions = type.GetArrayRank();
            elementType = TypeReferenceWithReflectionFactory.CreateReference(type.GetElementType());
        }

        public override int Dimensions
        {
            get { return dimensions; }
        }

        public override ITypeReferenceWithReflection ElementType
        {
            get { return elementType; }
        }

        public Type Type
        {
            get { return type; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitArrayTypeReferenceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
