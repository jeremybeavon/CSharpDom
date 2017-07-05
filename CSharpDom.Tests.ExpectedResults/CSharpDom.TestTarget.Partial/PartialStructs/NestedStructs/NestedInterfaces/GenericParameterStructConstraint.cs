namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
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
