namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties
{
    public struct StructWithNestedSealedPartialClassWithPrivateProperty
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
