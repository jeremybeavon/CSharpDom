using CSharpDom.Common;
using System.ComponentModel;

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

        public void Accept(IGenericVisitor visitor)
        {
            if (ArrayTypeReference != null)
            {
                ArrayTypeReference.Accept(visitor);
            }
            else if (ClassReference != null)
            {
                ClassReference.Accept(visitor);
            }
            else if (DelegateReference != null)
            {
                DelegateReference.Accept(visitor);
            }
            else if (EnumReference != null)
            {
                EnumReference.Accept(visitor);
            }
            else if (GenericParameterReference != null)
            {
                GenericParameterReference.Accept(visitor);
            }
            else if (InterfaceReference != null)
            {
                InterfaceReference.Accept(visitor);
            }
            else if (StructReference != null)
            {
                StructReference.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (ArrayTypeReference != null)
            {
                ArrayTypeReference.AcceptChildren(visitor);
            }
            else if (ClassReference != null)
            {
                ClassReference.AcceptChildren(visitor);
            }
            else if (DelegateReference != null)
            {
                DelegateReference.AcceptChildren(visitor);
            }
            else if (EnumReference != null)
            {
                EnumReference.AcceptChildren(visitor);
            }
            else if (GenericParameterReference != null)
            {
                GenericParameterReference.AcceptChildren(visitor);
            }
            else if (InterfaceReference != null)
            {
                InterfaceReference.AcceptChildren(visitor);
            }
            else if (StructReference != null)
            {
                StructReference.AcceptChildren(visitor);
            }
        }
    }
}
