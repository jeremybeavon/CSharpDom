namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
