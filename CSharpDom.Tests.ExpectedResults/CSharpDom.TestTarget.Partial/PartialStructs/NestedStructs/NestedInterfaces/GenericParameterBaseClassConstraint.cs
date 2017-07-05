namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
