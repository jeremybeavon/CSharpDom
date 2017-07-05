namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNewProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
