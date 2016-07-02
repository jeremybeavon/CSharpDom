namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
