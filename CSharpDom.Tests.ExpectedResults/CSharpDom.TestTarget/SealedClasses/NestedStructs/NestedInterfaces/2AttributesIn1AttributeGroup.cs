namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedInterfaces
{
    public sealed class SealedClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public interface Interface
            {
            }
        }
    }
}
