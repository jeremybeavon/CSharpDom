namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedSealedClassWithNestedDelegateWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
