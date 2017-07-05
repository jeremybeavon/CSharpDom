namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedInterfaces
{
    public sealed class SealedClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint
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
