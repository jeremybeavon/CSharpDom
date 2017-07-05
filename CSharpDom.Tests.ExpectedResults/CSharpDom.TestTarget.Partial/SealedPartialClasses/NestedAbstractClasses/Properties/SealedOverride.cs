namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithSealedOverrideProperty
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
