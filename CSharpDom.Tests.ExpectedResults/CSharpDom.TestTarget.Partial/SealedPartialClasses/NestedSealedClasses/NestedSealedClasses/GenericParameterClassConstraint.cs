namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
