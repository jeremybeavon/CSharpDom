namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
