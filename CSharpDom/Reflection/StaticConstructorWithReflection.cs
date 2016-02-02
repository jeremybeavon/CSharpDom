using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;

namespace CSharpDom.Reflection
{
    public abstract class StaticConstructorWithReflection :
        AbstractStaticConstructor<AttributeWithReflection, ITypeWithReflection, ILMethodBodyWithReflectionEmit>
    {
    }
}
