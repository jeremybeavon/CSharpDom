namespace CSharpDom.TestTarget.Structs.NestedClasses.Constructors
{
    public struct StructWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
