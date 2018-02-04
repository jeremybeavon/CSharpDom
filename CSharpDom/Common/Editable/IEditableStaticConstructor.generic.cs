using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        IEditableStaticConstructor,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableBody<TMethodBody>,
        IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TMethodBody : IEditableMethodBody
    {
    }
}