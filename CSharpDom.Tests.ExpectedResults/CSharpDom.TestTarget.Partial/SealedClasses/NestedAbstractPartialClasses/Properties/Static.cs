namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithStaticProperty
    {
        public abstract partial class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
