namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
