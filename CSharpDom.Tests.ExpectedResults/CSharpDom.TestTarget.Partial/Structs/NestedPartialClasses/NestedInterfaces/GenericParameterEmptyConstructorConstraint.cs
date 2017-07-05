namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
