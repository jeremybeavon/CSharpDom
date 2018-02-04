using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditablePartial : IHasPartial
    {
        new bool IsPartial { get; set; }
    }
}