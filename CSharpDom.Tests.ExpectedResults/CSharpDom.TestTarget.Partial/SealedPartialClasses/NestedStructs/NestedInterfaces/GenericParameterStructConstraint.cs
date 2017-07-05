namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
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
