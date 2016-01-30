using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class EnumReference : IEnumReference
    {
        public string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
