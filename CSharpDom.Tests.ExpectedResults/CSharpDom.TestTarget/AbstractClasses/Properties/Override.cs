namespace CSharpDom.TestTarget.AbstractClasses.Properties
{
    public abstract class AbstractClassWithOverrideProperty : BaseClassWithProperty
    {
        public override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
