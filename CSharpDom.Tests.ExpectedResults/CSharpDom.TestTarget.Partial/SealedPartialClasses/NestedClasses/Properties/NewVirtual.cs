namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
