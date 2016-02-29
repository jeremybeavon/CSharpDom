using CSharpDom.BaseClasses;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ArrayTypeReferenceWithMonoCecil :
        AbstractArrayTypeReference<ITypeReferenceWithMonoCecil>,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;
        private readonly int dimensions;
        private readonly ITypeReferenceWithMonoCecil elementType;

        internal ArrayTypeReferenceWithMonoCecil(AssemblyWithMonoCecil assembly, TypeReference type)
        {
            this.type = type;
            //dimensions = type..GetArrayRank();
            elementType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, type.GetElementType());
        }

        public override int Dimensions
        {
            get { return dimensions; }
        }

        public override ITypeReferenceWithMonoCecil ElementType
        {
            get { return elementType; }
        }

        public TypeReference TypeReference
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
