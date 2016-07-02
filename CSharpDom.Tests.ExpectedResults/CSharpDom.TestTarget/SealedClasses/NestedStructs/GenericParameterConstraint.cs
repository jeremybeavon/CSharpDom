namespace CSharpDom.TestTarget.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
