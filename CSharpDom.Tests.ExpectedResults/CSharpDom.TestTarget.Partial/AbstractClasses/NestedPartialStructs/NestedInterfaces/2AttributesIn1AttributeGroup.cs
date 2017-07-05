namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroup
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
