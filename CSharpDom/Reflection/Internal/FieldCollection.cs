using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class FieldCollection<TField> : VisitableNotSupported<IGenericVisitor>, IFieldCollection
    {
        private readonly Lazy<IReadOnlyCollection<TField>> fields;

        public FieldCollection(Func<IReadOnlyCollection<TField>> fields)
        {
            Fields = fields;
        }

        public IReadOnlyCollection<TField> Fields
        {
            get { return fields.Value; }
        }
    }
}
