namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Constructors
{
    public sealed class SealedClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
    {
        public abstract class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
