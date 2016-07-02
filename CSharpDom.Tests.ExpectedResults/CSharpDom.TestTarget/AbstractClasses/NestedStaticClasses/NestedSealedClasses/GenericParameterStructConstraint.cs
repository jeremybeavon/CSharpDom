namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
