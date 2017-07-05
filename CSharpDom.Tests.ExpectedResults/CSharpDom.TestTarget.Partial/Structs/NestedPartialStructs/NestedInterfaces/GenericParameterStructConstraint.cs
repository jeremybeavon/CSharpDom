namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
