namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedInterfaces
{
    public struct StructWithNestedSealedClassWithNestedInterfaceWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public interface Interface
            {
            }
        }
    }
}
