namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
