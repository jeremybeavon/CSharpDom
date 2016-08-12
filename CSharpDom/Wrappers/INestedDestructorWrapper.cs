using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Wrappers
{
    public interface INestedDestructorWrapper :
        INestedDestructor<IAttributeGroupWrapper, INestedClassWrapper, IMethodBodyWrapper>
    {
    }
}
