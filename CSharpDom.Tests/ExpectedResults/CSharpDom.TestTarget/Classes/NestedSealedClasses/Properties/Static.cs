namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties
{
    public class ClassWithNestedSealedClassWithStaticProperty
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
