using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassTypeDefinition<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference> :
        IEditableClassTypeDefinition,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableBaseClass<TClassReference>,
        IHasEditableImplementedInterfaces<TInterfaceReference>,
        IClassTypeDefinition<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TClassReference : IEditableClassReference
        where TInterfaceReference : IEditableInterfaceReference
    {
    }
}