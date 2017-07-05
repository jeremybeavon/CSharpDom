namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithPrivateProperty
    {
        public sealed class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
