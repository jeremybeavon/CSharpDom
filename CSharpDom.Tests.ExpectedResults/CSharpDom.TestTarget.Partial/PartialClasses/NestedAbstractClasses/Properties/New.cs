namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Properties
{
    public partial class PartialClassWithNestedAbstractClassWithNewProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
