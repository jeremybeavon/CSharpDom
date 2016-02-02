using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        IStaticConstructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TMethodBody : IMethodBody
    {
    }
}
