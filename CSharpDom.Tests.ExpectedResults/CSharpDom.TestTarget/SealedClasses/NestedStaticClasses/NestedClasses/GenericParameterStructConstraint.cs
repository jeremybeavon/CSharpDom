namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
