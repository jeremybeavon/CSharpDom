using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassFieldCollection : AbstractClassFieldCollection<ReadOnlyClassField, ReadOnlyClassField>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassField> constants;
        private readonly IReadOnlyCollection<ReadOnlyClassField> fields;

        public ReadOnlyClassFieldCollection(ClassBody body)
        {
            List<ReadOnlyClassField> constants = new List<ReadOnlyClassField>();
            List<ReadOnlyClassField> fields = new List<ReadOnlyClassField>();
            foreach (ClassField classField in body.Fields)
            {
                ReadOnlyClassField field = new ReadOnlyClassField(classField);
                fields.Add(field);
            }

            this.constants = constants;
            this.fields = fields;
        }

        public override IReadOnlyCollection<ReadOnlyClassField> Constants
        {
            get { return constants; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassField> Fields
        {
            get { return fields; }
        }
    }
}
