namespace CSharpDom.TestTarget.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
