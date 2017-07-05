namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
