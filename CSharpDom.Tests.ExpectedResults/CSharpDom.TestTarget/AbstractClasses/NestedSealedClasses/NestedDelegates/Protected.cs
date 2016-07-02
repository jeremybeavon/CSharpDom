namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithProtectedNestedDelegate
    {
        public sealed class Class
        {
            protected delegate void ProtectedDelegate();
        }
    }
}
