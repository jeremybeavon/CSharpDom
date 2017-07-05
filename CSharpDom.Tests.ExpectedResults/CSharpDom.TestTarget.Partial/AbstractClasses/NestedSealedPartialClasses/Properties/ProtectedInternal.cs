namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithProtectedInternalProperty
    {
        public sealed partial class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
