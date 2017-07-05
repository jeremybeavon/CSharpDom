namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNewStaticProperty : BaseClassWithProperty
    {
        public new static string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
