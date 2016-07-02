namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
