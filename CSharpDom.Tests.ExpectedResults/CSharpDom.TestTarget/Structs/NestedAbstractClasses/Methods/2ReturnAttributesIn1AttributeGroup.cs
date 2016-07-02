namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods
{
    public struct StructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
