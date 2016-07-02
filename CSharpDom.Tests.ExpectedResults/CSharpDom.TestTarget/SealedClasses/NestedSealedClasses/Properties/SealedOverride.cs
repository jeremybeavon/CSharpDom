namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties
{
    public sealed class SealedClassWithNestedSealedClassWithSealedOverrideProperty
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
