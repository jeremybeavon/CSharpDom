namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
