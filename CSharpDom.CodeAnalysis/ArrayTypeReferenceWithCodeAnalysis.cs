using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ArrayTypeReferenceWithCodeAnalysis :
        AbstractArrayTypeReference<ITypeReferenceWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;
        private readonly int dimensions;
        private readonly ITypeReferenceWithCodeAnalysis elementType;

        internal ArrayTypeReferenceWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, TypeReference type, MemberReference member)
        {
            this.type = type;
            //dimensions = type..GetArrayRank();
            elementType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, type.GetElementType(), member);
        }

        public override int Dimensions
        {
            get { return dimensions; }
        }

        public override ITypeReferenceWithCodeAnalysis ElementType
        {
            get { return elementType; }
        }

        public TypeReference TypeReference
        {
            get { return type; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitArrayTypeReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
