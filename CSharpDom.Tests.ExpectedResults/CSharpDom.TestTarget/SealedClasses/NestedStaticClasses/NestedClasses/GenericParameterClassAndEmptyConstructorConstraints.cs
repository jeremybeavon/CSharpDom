namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
