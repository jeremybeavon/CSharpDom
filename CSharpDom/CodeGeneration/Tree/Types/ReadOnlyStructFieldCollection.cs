using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructFieldCollection : AbstractStructFieldCollection<ReadOnlyStructField, IStructConstant>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructField> fields;

        public ReadOnlyStructFieldCollection(StructBody body)
        {
            fields = body.Fields.ToArray(field => new ReadOnlyStructField(field));
        }

        public override IReadOnlyCollection<IStructConstant> Constants
        {
            get { return new IStructField[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructField> Fields
        {
            get { return fields; }
        }
    }
}
