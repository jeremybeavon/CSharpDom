namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
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
