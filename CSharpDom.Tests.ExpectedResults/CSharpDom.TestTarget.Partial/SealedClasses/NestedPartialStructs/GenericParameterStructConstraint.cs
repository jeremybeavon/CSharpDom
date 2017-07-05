namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
