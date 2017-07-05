namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Properties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
