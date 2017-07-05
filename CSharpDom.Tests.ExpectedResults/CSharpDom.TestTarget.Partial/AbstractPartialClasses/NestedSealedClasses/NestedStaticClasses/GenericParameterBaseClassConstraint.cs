namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
