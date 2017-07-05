namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewProperty
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
