namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties
{
    public sealed class SealedClassWithNestedPartialClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
