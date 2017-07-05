namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedDelegateWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
