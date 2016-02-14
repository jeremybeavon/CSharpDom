namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers
    {
        public sealed class Class
        {
            public string this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
