namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedInterfaces
{
    public partial class PartialClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
