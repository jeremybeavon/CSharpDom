namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
