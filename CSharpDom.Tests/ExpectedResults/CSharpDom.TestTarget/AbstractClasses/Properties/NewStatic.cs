namespace CSharpDom.TestTarget.AbstractClasses.Properties
{
    public abstract class AbstractClassWithNewStaticProperty : BaseClassWithProperty
    {
        public new static string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
