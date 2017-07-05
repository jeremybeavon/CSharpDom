namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
