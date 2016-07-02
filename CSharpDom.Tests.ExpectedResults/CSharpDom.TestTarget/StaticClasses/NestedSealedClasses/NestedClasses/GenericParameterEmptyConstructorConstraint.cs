namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
