namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
