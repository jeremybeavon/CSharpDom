namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
