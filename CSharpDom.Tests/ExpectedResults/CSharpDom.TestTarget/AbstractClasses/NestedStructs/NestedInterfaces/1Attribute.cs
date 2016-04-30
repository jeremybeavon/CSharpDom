namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStructWithNestedInterfaceWith1Attribute
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
