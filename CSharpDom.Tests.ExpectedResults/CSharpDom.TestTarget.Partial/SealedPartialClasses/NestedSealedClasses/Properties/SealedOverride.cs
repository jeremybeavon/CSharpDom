namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithSealedOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
