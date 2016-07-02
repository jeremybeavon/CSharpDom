namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
