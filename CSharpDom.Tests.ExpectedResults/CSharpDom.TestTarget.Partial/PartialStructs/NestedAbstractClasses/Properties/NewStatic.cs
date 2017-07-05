namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewStaticProperty
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
