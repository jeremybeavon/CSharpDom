namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedPartialClassWithNewVirtualProperty
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
