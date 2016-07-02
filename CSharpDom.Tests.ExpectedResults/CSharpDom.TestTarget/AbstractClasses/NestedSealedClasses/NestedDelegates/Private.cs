namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithPrivateNestedDelegate
    {
        public sealed class Class
        {
            private delegate void PrivateDelegate();
        }
    }
}
