namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedInterfaces
{
    public sealed class SealedClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
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
