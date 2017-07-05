namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedDelegateWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
