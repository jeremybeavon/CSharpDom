namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
