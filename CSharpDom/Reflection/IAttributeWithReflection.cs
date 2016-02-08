using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection
{
    public interface IAttributeWithReflection :
        IAttribute<ClassReferenceWithReflection, UnnamedAttributeValueWithReflection, NamedAttributeValueWithReflection>
    {
    }
}
