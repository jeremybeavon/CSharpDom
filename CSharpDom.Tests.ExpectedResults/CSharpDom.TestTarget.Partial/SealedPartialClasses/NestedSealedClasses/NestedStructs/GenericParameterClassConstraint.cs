namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
