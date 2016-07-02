namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedInterfaces
{
    public struct StructWithNestedSealedClassWithNestedInterfaceWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public interface Interface
            {
            }
        }
    }
}
