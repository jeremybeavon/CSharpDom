namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithOverrideProperty
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
