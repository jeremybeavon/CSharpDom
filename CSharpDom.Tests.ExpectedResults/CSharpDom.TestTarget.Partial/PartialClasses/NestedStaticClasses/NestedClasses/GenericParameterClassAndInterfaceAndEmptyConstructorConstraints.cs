namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
