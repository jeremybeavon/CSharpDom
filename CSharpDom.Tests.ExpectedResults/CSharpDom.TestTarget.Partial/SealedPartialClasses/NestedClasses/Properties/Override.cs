namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedClassWithOverrideProperty
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
