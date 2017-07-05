namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedInterfaces
{
    public partial class PartialClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
