namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
