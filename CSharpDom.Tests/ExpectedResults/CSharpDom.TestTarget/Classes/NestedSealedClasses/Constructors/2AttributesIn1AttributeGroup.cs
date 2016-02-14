namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors
{
    public class ClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public Class()
            {
            }
        }
    }
}
