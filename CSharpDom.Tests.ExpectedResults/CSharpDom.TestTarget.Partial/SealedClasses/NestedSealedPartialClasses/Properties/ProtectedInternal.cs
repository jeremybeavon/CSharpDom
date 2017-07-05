namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithProtectedInternalProperty
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
