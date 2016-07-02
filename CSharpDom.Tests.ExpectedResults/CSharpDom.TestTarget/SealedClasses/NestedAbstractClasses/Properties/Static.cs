namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractClassWithStaticProperty
    {
        public abstract class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
