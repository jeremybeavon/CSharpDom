namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
