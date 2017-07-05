namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties
{
    public struct StructWithNestedSealedPartialClassWithNewStaticProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
