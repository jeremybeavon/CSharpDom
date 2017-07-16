using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class TypeReferenceFactory : AbstractFactory<ITypeReference, TypeReference>
    {
        public TypeReferenceFactory(ITypeReference typeReference)
            : base(typeReference)
        {
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            Value = new TypeReference()
            {
                ArrayTypeReference = new ArrayTypeReferenceFactory(arrayTypeReference).Value
            };
        }

        public override void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            Value = new TypeReference()
            {
                BuiltInTypeReference = new BuiltInTypeReferenceFactory(builtInTypeReference).Value
            };
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            Value = new TypeReference()
            {
                ClassReference = new ClassReferenceFactory(classReference).Value
            };
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            Value = new TypeReference()
            {
                DelegateReference = new DelegateReferenceFactory(delegateReference).Value
            };
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            Value = new TypeReference()
            {
                EnumReference = new EnumReferenceFactory(enumReference).Value
            };
        }
        
        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            Value = new TypeReference()
            {
                GenericParameterReference = new GenericParameterReferenceFactory(genericParameterReference).Value
            };
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            Value = new TypeReference()
            {
                InterfaceReference = new InterfaceReferenceFactory(interfaceReference).Value
            };
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            Value = new TypeReference()
            {
                NestedTypeReference = new NestedTypeReferenceFactory(nestedTypeReference).Value
            };
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            Value = new TypeReference()
            {
                StructReference = new StructReferenceFactory(structReference).Value
            };
        }
    }
}
