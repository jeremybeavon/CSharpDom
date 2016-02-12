using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructFieldCollection : IStructFieldCollection<StructField, StructConstant>
    {
        public StructFieldCollection()
        {
            Fields = new List<StructField>();
            Constants = new List<StructConstant>();
        }

        public List<StructField> Fields { get; set; }

        public List<StructConstant> Constants { get; set; }

        public int Count
        {
            get { return Fields.Count + Constants.Count; }
        }

        IReadOnlyCollection<StructConstant> IHasConstants<StructConstant>.Constants
        {
            get { return Constants; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructFieldCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitStructFieldCollectionChildren(this, visitor);
        }

        public IEnumerator<StructField> GetEnumerator()
        {
            return Fields.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
