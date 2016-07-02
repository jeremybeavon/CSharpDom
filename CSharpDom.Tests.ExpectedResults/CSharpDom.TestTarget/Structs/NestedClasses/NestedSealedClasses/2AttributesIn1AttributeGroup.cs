namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedSealedClasses
{
    public struct StructWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
