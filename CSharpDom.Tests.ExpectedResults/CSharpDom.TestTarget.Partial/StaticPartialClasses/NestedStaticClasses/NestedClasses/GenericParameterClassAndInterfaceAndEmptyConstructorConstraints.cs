namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
