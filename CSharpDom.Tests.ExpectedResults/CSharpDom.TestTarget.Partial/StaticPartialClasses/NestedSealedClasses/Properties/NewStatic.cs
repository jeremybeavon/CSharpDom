namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewStaticProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
