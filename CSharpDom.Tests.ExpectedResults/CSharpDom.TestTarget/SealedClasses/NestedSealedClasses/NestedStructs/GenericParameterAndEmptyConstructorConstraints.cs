namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
