namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses
{
    public class ClassWithNestedSealedClassWithNestedClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
