namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithInternalProperty
    {
        public sealed class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
