namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
