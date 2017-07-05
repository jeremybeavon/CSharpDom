namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedPartialClassWithSealedOverrideProperty
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
