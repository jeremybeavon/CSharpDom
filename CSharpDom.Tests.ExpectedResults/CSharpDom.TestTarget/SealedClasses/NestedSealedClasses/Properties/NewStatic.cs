namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties
{
    public sealed class SealedClassWithNestedSealedClassWithNewStaticProperty
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
