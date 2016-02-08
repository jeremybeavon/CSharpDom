using CSharpDom.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization
{
    public sealed class TypeReference : ITypeReference
    {
        [DefaultValue(null)]
        public ArrayTypeReference ArrayTypeReference { get; set; }

        [DefaultValue(null)]
        public BuiltInTypeReference BuiltInTypeReference { get; set; }

        [DefaultValue(null)]
        public ClassReference ClassReference { get; set; }

        [DefaultValue(null)]
        public DelegateReference DelegateReference { get; set; }

        [DefaultValue(null)]
        public EnumReference EnumReference { get; set; }

        [DefaultValue(null)]
        public GenericParameterReference GenericParameterReference { get; set; }

        [DefaultValue(null)]
        public InterfaceReference InterfaceReference { get; set; }

        [DefaultValue(null)]
        public StructReference StructReference { get; set; }

        private IEnumerable<ITypeReference> TypeReferences
        {
            get
            {
                yield return ArrayTypeReference;
                yield return BuiltInTypeReference;
                yield return ClassReference;
                yield return DelegateReference;
                yield return EnumReference;
                yield return GenericParameterReference;
                yield return InterfaceReference;
                yield return StructReference;
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            ITypeReference typeReference = TypeReferences.FirstOrDefault(reference => reference != null);
            if (typeReference != null)
            {
                typeReference.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            ITypeReference typeReference = TypeReferences.FirstOrDefault(reference => reference != null);
            if (typeReference != null)
            {
                typeReference.AcceptChildren(visitor);
            }
        }
    }
}
