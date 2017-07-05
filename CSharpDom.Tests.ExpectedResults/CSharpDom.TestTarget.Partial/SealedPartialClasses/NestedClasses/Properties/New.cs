namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewProperty
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
