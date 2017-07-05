namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithOverrideProperty
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
