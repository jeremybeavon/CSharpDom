namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
