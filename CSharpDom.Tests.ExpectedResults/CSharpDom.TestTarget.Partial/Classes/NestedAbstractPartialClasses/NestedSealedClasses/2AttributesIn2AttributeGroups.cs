namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
