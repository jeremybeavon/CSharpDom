namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithSealedOverrideProperty
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
