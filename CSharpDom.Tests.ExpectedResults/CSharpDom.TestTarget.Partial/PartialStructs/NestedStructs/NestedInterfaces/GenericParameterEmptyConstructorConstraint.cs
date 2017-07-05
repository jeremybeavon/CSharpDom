namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
