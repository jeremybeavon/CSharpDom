namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
