namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedDelegates
{
    public struct StructWithNestedStaticPartialClassWithNestedDelegateWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
