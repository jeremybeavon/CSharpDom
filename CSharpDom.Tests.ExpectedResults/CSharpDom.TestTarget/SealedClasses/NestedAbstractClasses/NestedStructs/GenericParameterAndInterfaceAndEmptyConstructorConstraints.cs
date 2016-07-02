namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
