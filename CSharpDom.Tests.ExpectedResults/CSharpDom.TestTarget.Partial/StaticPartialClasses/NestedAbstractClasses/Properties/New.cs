namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Properties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNewProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
