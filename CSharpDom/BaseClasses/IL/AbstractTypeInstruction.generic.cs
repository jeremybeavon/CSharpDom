using CSharpDom.Common.IL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractTypeInstruction<TTypeReference> :
        AbstractTypeInstruction,
        ITypeInstruction<TTypeReference>
    {
        public abstract TTypeReference Type { get; }
    }
}
