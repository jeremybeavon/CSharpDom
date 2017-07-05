namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
