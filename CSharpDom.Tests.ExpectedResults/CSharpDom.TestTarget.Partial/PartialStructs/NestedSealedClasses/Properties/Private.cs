namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties
{
    public partial struct PartialStructWithWithNestedSealedClassWithPrivateProperty
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
