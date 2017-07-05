namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
