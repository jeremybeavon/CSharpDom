namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
