namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
