namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
