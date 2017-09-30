using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IClassTypeDefinition<
        TAttributeGroup,
        TGenericParameter,
        TClassReference,
        TInterfaceReference> :
        IClassTypeDefinition,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasBaseClass<TClassReference>,
        IHasImplementedInterfaces<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
    {
    }
}
