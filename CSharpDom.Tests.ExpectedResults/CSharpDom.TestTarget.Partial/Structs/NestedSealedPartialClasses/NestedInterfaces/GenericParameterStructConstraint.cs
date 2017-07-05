namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
