namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
