namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
