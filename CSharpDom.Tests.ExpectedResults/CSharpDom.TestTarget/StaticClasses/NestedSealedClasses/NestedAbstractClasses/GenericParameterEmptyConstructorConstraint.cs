namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
