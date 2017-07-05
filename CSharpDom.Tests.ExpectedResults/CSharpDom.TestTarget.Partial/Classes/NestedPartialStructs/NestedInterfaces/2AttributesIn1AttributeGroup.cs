namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroup
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
