namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties
{
    public sealed class SealedClassWithNestedSealedClassWithOverrideProperty
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
