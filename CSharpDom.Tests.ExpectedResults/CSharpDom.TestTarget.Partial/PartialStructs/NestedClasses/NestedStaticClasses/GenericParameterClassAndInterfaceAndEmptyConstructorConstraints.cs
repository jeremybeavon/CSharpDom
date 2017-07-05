namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
