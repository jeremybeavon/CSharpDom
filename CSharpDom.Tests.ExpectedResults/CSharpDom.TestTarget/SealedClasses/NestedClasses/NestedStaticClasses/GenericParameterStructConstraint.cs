namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
