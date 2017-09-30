using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IClassTypeDefinitionsBuilder
    {
        IEnumerable<TClassTypeDefinition> WithType<TClassTypeDefinition>()
            where TClassTypeDefinition : IClassTypeDefinition;
    }
}
