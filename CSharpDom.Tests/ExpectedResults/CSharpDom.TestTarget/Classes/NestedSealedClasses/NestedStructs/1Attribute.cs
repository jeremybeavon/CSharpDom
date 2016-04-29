namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
