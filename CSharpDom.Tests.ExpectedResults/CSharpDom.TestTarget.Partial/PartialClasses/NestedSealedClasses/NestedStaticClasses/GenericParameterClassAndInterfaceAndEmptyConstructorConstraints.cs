namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
