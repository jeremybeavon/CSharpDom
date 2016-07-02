namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractClassWithInternalProperty
    {
        public abstract class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
