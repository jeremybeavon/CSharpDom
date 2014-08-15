using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IDelegateWithSymbol : IDelegate, IHasSymbol<INamedTypeSymbol>
    {
    }
}
