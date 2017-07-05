namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
