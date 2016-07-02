namespace CSharpDom.TestTarget.Structs.NestedDelegates
{
    public struct StructWithNestedDelegateWithParametersWithAttributes
    {
        public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
    }
}
