namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithProtectedProperty
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
