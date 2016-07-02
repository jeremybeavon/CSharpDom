namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithOrOperatorOverload
    {
        public static ClassWithOrOperatorOverload operator |(ClassWithOrOperatorOverload parameter1, ClassWithOrOperatorOverload parameter2)
        {
            return default(ClassWithOrOperatorOverload);
        }
    }
}
