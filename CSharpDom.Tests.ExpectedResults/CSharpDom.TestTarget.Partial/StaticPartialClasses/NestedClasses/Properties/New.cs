namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedClassWithNewProperty
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
