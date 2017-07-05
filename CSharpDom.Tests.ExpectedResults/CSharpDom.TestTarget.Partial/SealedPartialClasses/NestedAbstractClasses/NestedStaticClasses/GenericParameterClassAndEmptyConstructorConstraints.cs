namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
