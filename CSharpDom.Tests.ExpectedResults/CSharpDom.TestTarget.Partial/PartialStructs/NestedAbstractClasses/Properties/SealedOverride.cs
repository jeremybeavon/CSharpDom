namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties
{
    public partial struct PartialStructWithNestedAbstractClassWithSealedOverrideProperty
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
