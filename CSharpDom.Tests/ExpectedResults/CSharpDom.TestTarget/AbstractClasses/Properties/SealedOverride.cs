namespace CSharpDom.TestTarget.AbstractClasses.Properties
{
    public abstract class AbstractClassWithSealedOverrideProperty : BaseClassWithProperty
    {
        public sealed override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
