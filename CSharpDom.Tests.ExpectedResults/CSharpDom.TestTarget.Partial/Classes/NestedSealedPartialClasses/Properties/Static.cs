namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties
{
    public class ClassWithNestedSealedPartialClassWithStaticProperty
    {
        public sealed partial class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
