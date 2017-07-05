namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewStaticProperty
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
