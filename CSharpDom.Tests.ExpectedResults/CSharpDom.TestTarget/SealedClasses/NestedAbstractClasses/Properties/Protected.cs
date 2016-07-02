namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractClassWithProtectedProperty
    {
        public abstract class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
