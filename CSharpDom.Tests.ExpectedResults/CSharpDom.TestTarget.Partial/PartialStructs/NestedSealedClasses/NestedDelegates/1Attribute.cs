namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedDelegateWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
