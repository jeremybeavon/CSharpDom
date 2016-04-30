namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithStaticProperty
    {
        public sealed class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
