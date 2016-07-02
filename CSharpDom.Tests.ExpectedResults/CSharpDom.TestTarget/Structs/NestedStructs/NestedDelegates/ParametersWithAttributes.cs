namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public struct Struct
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
