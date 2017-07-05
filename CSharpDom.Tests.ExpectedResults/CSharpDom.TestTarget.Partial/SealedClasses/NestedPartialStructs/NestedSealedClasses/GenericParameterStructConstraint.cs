namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
