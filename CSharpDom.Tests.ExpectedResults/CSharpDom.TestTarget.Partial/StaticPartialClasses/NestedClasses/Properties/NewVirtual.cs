namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedClassWithNewVirtualProperty
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
