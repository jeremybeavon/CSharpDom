namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods
{
    public struct StructWithNestedAbstractClassWithMethodWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
