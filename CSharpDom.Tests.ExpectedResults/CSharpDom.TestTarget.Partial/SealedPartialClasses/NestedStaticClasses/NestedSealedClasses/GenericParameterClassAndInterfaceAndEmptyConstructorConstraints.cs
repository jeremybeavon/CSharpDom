namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
