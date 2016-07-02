namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
