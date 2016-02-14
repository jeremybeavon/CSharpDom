namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassExplicitInterfaceWithMethodWithParametersWithAttributes
    {
        public class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
