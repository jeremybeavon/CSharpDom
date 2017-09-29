namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties
{
    public partial struct PartialStructWithNestedSealedClassWithProtectedProperty
    {
        public sealed class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
