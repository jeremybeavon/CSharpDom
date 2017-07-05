namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedInterfaces
{
    public partial class PartialClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
