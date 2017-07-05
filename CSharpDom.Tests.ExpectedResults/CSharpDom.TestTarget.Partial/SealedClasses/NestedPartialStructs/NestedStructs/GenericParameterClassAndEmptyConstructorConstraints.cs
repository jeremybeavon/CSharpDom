namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
