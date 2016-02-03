using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal interface IPropertyFactory<TProperty, TIndexer>
    {
        TProperty CreateProperty(ITypeWithReflection declaringType, PropertyInfo property);

        TIndexer CreateIndexer(ITypeWithReflection declaringType, PropertyInfo property);
    }
}
