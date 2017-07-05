namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
