using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil
{
    public interface IAttributeWithMonoCecil :
        IAttribute<ClassReferenceWithMonoCecil, UnnamedAttributeValueWithMonoCecil, NamedAttributeValueWithMonoCecil>
    {
    }
}
