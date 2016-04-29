namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties
{
    public class ClassWithNestedSealedClassWithPublicProperty
    {
        public sealed class Class
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
