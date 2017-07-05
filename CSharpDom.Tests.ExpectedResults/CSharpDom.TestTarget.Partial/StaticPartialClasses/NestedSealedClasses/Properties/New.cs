namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
