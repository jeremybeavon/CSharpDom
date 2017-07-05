namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
