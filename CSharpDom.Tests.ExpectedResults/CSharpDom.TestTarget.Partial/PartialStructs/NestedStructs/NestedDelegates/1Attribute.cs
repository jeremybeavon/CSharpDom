namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStructWithNestedDelegateWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
