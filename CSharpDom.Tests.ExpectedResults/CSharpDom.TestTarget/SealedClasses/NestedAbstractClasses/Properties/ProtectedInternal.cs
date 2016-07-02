namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractClassWithProtectedInternalProperty
    {
        public abstract class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
