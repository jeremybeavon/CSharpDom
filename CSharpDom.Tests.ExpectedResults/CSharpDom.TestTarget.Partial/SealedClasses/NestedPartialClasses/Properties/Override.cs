namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedPartialClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
