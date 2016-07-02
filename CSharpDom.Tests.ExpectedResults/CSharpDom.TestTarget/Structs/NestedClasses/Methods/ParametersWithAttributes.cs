namespace CSharpDom.TestTarget.Structs.NestedClasses.Methods
{
    public struct StructWithNestedClassWithMethodWithParametersWithAttributes
    {
        public class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
