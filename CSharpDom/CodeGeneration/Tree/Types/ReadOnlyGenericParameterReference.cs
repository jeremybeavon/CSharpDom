using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyGenericParameterReference : AbstractGenericParameterReference
    {
        private readonly string name;

        public ReadOnlyGenericParameterReference(GenericParameterReference genericParameterReference)
        {
            if (!string.IsNullOrWhiteSpace(genericParameterReference.TypeText))
            {
                name = genericParameterReference.TypeText;
            }
            else if (genericParameterReference.GenericParameter != null)
            {
                name = genericParameterReference.GenericParameter.Name;
            }
            else if (genericParameterReference.Type != null)
            {
                name = genericParameterReference.Type.Name;
            }
        }

        public override string Name
        {
            get { return name; }
        }
    }
}
