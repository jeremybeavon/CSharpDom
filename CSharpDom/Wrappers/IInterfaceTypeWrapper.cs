using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers
{
    public interface IInterfaceTypeWrapper :
        IInterfaceType<
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IInterfaceEventWrapper,
            IInterfacePropertyWrapper,
            IInterfaceIndexerWrapper,
            IInterfaceMethodWrapper>
    {
    }
}
