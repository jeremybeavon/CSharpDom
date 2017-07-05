namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
