namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithProtectedProperty
    {
        public sealed class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
