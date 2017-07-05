namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
