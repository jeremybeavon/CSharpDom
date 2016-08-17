using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableBasicType<TEvent, TProperty, TIndexer, TMethod> :
        IBasicType<TEvent, TProperty, TIndexer, TMethod>
    {
        public virtual ICollection<TEvent> Events { get; set; }

        public virtual ICollection<TIndexer> Indexers { get; set; }

        public virtual ICollection<TMethod> Methods { get; set; }

        public virtual ICollection<TProperty> Properties { get; set; }

        IReadOnlyCollection<TEvent> IHasEvents<TEvent>.Events
        {
            get { return new ReadOnlyCollectionWrapper<TEvent>(Events); }
        }

        IReadOnlyCollection<TIndexer> IHasIndexers<TIndexer>.Indexers
        {
            get { return new ReadOnlyCollectionWrapper<TIndexer>(Indexers); }
        }

        IReadOnlyCollection<TMethod> IHasMethods<TMethod>.Methods
        {
            get { return new ReadOnlyCollectionWrapper<TMethod>(Methods); }
        }

        IReadOnlyCollection<TProperty> IHasProperties<TProperty>.Properties
        {
            get { return new ReadOnlyCollectionWrapper<TProperty>(Properties); }
        }
    }
}
