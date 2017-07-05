namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Properties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNewStaticProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
