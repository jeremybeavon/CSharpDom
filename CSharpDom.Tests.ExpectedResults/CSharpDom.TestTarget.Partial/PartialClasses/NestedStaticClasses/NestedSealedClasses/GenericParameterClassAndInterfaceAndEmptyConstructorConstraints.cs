namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
