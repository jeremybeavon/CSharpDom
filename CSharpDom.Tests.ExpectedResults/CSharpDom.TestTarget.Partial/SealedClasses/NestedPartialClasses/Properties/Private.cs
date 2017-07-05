namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedPartialClassWithPrivateProperty
    {
        public partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
