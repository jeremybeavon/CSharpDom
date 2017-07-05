namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Properties
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
