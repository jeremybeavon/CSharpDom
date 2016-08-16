using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableBasicType<TEvent, TProperty, TIndexer, TMethod> :
        IBasicType<TEvent, TProperty, TIndexer, TMethod>
    {
        public virtual IReadOnlyCollection<TEvent> Events { get; set; }

        public virtual IReadOnlyCollection<TIndexer> Indexers { get; set; }

        public virtual IReadOnlyCollection<TMethod> Methods { get; set; }

        public virtual IReadOnlyCollection<TProperty> Properties { get; set; }
    }
}
