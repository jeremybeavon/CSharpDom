namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Properties
{
    public partial class PartialClassWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
