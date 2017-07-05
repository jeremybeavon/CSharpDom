namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
