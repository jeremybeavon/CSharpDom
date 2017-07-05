namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPrivateNestedDelegate
    {
        public sealed partial class Class
        {
            private delegate void PrivateDelegate();
        }
    }
}
