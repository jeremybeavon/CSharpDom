namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
