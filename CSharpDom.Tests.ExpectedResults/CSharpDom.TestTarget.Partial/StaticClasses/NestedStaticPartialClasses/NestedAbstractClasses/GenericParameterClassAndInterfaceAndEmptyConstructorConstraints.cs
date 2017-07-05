namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
