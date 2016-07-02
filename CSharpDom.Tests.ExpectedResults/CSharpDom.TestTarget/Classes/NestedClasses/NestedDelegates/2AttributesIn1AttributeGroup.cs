namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedDelegates
{
    public class ClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
