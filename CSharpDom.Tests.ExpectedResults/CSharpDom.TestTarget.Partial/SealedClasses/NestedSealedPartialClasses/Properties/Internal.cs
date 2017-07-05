namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithInternalProperty
    {
        public sealed partial class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
