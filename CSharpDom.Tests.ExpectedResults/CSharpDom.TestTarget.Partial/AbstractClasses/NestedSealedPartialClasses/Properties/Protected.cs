namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithProtectedProperty
    {
        public sealed partial class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
