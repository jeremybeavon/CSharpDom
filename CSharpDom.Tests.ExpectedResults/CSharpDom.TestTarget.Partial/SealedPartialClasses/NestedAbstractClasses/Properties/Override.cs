namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
