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
    public sealed class ReadOnlyInterfaceReference : AbstractInterfaceReference<ReadOnlyTypeReference>
    {
        private readonly string name;
        private readonly IReadOnlyList<ReadOnlyTypeReference> genericParameters;

        public ReadOnlyInterfaceReference(InterfaceReference interfaceReference)
        {
            genericParameters = interfaceReference.GenericParameters.ToArray(parameter => new ReadOnlyTypeReference(parameter));
            if (!string.IsNullOrWhiteSpace(interfaceReference.TypeText))
            {
                name = interfaceReference.TypeText;
            }
            else if (interfaceReference.ClassNestedInterface != null)
            {
                name = interfaceReference.ClassNestedInterface.Name;
            }
            else if (interfaceReference.Interface != null)
            {
                name = interfaceReference.Interface.Name;
            }
            else if (interfaceReference.StructNestedInterface != null)
            {
                name = interfaceReference.StructNestedInterface.Name;
            }
            else if (interfaceReference.Type != null)
            {
                name = interfaceReference.Type.Name;
            }
        }

        public override IReadOnlyList<ReadOnlyTypeReference> GenericParameters
        {
            get { return genericParameters; }
        }

        public override string Name
        {
            get { return name; }
        }

        public static IReadOnlyCollection<ReadOnlyInterfaceReference> Create(IEnumerable<InterfaceReference> interfaceReferences)
        {
            return interfaceReferences.ToArray(interfaceReference => new ReadOnlyInterfaceReference(interfaceReference));
        }
    }
}
