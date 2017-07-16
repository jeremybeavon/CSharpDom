using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyDelegateReference : AbstractDelegateReference<ReadOnlyTypeReference>
    {
        private readonly IReadOnlyList<ReadOnlyTypeReference> genericParameters;
        private readonly string name;

        public ReadOnlyDelegateReference(DelegateReference delegateReference)
        {
            genericParameters = delegateReference.GenericParameters.ToArray(parameter => new ReadOnlyTypeReference(parameter));
            if (!string.IsNullOrWhiteSpace(delegateReference.TypeText))
            {
                name = delegateReference.TypeText;
            }
            else if (delegateReference.ClassNestedDelegate != null)
            {
                name = delegateReference.ClassNestedDelegate.Name;
            }
            else if (delegateReference.Delegate != null)
            {
                name = delegateReference.Delegate.Name;
            }
            else if (delegateReference.StructNestedDelegate != null)
            {
                name = delegateReference.StructNestedDelegate.Name;
            }
            else if (delegateReference.Type != null)
            {
                name = delegateReference.Type.Name;
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
    }
}
