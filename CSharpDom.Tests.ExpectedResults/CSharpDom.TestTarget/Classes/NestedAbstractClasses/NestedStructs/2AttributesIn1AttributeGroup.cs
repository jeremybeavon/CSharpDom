namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStructs
{
    public class ClassWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroup
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
