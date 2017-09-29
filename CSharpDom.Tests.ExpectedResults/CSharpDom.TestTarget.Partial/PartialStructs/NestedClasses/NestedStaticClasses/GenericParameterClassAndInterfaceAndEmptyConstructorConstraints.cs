namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
