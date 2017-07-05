namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Properties
{
    public partial class PartialClassWithNestedAbstractClassWithNewStaticProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
