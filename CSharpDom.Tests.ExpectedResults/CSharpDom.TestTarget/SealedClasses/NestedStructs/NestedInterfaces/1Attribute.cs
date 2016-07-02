namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedInterfaces
{
    public sealed class SealedClassWithNestedStructWithNestedInterfaceWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public interface Interface
            {
            }
        }
    }
}
