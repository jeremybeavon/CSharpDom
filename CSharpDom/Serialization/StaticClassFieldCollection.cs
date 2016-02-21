using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassFieldCollection : IStaticClassFieldCollection<StaticClassField, StaticClassConstant>
    {
        public StaticClassFieldCollection()
        {
            Fields = new List<StaticClassField>();
            Constants = new List<StaticClassConstant>();
        }

        public List<StaticClassField> Fields { get; set; }

        public List<StaticClassConstant> Constants { get; set; }

        public int Count
        {
            get { return Fields.Count + Constants.Count; }
        }

        IReadOnlyCollection<StaticClassConstant> IHasConstants<StaticClassConstant>.Constants
        {
            get { return Constants; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassFieldCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassFieldCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassField> GetEnumerator()
        {
            return Fields.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
