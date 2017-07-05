namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPrivateProperty
    {
        public sealed partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
