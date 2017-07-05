namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
