namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
