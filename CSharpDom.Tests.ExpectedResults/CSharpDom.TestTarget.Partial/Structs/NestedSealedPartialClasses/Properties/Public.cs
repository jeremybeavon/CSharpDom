namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties
{
    public struct StructWithNestedSealedPartialClassWithPublicProperty
    {
        public sealed partial class Class
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
