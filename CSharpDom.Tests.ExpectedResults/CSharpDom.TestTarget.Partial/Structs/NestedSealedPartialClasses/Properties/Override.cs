namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties
{
    public struct StructWithNestedSealedPartialClassWithOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
