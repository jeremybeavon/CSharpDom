namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
