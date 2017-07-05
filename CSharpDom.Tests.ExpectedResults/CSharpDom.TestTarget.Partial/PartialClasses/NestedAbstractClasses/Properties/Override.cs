namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Properties
{
    public partial class PartialClassWithNestedAbstractClassWithOverrideProperty
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
