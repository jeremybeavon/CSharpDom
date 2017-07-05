namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
