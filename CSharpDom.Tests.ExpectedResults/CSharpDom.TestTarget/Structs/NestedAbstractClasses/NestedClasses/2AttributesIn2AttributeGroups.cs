namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses
{
    public struct StructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
