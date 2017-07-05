namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
