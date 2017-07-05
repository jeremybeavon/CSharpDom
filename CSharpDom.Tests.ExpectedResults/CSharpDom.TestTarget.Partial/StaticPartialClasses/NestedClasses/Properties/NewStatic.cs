namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedClassWithNewStaticProperty
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
