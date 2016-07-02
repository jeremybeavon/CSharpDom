namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithInternalNestedDelegate
    {
        public sealed class Class
        {
            internal delegate void InternalDelegate();
        }
    }
}
