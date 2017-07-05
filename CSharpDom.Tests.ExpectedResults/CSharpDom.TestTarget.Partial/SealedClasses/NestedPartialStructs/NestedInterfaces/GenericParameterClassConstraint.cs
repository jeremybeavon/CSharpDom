namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedInterfaces
{
    public sealed class SealedClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint
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
