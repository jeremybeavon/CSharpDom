namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
