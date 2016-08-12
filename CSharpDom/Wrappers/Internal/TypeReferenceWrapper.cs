using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class TypeReferenceWrapper : AbstractWrapper<ITypeReference>
    {
        private TypeReferenceWrapper(ITypeReference typeReference)
            : base(typeReference)
        {
        }

        public ITypeReferenceWrapper TypeReference { get; private set; }

        public static ITypeReferenceWrapper Create(ITypeReference typeReference)
        {
            return new TypeReferenceWrapper(typeReference).TypeReference;
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            TypeReference = new ArrayTypeReferenceWrapper(arrayTypeReference);
        }

        public override void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            TypeReference = new BuiltInTypeReferenceWrapper(builtInTypeReference);
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            TypeReference = new ClassReferenceWrapper(classReference);
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            TypeReference = new DelegateReferenceWrapper(delegateReference);
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            TypeReference = new EnumReferenceWrapper(enumReference);
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            TypeReference = new GenericParameterReferenceWrapper(genericParameterReference);
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            TypeReference = new InterfaceReferenceWrapper(interfaceReference);
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            TypeReference = new NestedTypeReferenceWrapper(nestedTypeReference);
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            TypeReference = new StructReferenceWrapper(structReference);
        }
    }
}
