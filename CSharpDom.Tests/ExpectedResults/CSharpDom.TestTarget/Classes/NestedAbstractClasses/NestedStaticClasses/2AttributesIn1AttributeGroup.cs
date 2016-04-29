namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
