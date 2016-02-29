using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasAssembly
    {
        AssemblyWithMonoCecil Assembly { get; }
    }
}
