namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods
{
    public partial struct PartialStructWithWithNestedSealedClassWithMethodWithParametersWithAttributes
    {
        public sealed class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
