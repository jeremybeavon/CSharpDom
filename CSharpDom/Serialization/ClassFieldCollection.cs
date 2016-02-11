using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassFieldCollection : IClassFieldCollection<ClassField, ClassConstant>
    {
        public ClassFieldCollection()
        {
            Fields = new List<ClassField>();
            Constants = new List<ClassConstant>();
        }

        public List<ClassField> Fields { get; set; }

        public List<ClassConstant> Constants { get; set; }

        public int Count
        {
            get { return Fields.Count + Constants.Count; }
        }

        IReadOnlyCollection<ClassConstant> IHasConstants<ClassConstant>.Constants
        {
            get { return Constants; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassFieldCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassFieldCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassField> GetEnumerator()
        {
            return Fields.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
