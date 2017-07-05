namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
