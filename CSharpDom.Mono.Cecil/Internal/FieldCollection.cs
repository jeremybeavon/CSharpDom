using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class FieldCollection<TField>
    {
        private readonly Lazy<IReadOnlyCollection<TField>> fields;

        public FieldCollection(Func<IReadOnlyCollection<TField>> fields)
        {
            this.fields = new Lazy<IReadOnlyCollection<TField>>(fields);
        }

        public IReadOnlyCollection<TField> Fields
        {
            get { return fields.Value; }
        }
    }
}
