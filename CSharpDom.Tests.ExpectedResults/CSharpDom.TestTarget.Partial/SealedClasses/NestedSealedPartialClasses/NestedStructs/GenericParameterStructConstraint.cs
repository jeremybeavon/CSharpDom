namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
