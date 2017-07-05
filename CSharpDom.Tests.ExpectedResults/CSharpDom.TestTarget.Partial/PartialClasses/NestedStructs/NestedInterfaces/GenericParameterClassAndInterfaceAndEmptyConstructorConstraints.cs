namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedInterfaces
{
    public partial class PartialClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
