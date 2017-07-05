namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Properties
{
    public partial class PartialClassWithNestedAbstractClassWithSealedOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
