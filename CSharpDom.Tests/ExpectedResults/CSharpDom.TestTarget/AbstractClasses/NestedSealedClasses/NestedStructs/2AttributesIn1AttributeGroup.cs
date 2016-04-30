namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
