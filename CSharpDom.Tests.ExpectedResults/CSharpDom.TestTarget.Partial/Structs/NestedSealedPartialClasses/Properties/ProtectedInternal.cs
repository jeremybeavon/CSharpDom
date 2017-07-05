namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties
{
    public struct StructWithNestedSealedPartialClassWithProtectedInternalProperty
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
