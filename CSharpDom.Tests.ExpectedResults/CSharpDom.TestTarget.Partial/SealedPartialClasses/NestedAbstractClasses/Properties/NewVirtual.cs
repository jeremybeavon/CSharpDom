namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
