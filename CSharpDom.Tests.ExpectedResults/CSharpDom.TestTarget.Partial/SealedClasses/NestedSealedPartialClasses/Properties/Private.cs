namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithPrivateProperty
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
