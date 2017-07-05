namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewStaticProperty
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
