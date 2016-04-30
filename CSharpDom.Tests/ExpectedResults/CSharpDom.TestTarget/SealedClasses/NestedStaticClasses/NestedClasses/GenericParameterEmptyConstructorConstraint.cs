namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
