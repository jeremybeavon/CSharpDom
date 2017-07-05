namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties
{
    public struct StructWithNestedSealedPartialClassWithInternalProperty
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
