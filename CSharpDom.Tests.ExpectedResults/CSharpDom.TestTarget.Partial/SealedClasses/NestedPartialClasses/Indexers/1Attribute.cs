namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedPartialClassWithIndexerWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
