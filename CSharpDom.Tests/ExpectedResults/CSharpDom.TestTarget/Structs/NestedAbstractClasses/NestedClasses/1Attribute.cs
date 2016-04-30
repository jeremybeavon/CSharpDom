namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses
{
    public struct StructWithNestedAbstractClassWithNestedClassWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
