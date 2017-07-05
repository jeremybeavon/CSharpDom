namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
