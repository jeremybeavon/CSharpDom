namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithMethodWithParametersWithAttributes
    {
        public sealed class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
