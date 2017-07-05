namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint
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
