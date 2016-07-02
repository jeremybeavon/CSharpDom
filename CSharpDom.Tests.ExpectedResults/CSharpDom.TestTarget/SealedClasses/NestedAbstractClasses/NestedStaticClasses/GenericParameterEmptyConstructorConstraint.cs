namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
