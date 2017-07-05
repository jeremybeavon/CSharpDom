namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
