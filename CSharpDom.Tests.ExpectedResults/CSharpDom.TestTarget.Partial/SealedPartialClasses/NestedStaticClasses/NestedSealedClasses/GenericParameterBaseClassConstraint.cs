namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
