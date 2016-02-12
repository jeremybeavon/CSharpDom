using CSharpDom.Common;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal interface IInternalClassTypeWithReflection : IClassTypeWithReflection, IHasDestructor<MethodInfo>
    {
    }
}
