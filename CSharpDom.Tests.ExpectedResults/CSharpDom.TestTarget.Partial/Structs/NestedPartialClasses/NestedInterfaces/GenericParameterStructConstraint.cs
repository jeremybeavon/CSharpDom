namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
