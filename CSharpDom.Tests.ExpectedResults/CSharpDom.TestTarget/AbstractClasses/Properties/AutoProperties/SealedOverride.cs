namespace CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithSealedOverrideAutoProperty : BaseClassWithProperty
    {
        public sealed override string Property { get; set; }
    }
}
