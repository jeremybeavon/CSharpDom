namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
