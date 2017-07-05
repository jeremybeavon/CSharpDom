namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
