namespace CSharpDom.TestTarget.Classes.Properties
{
    public class ClassWithSealedOverrideProperty : BaseClassWithProperty
    {
        public sealed override string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
