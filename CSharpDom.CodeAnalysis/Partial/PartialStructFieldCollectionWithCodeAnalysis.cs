using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructFieldCollectionWithCodeAnalysis :
        EditableStructFieldCollection<PartialStructFieldWithCodeAnalysis, PartialStructConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StructConstantWithCodeAnalysis,
            PartialStructConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<StructFieldWithCodeAnalysis, PartialStructFieldWithCodeAnalysis> fields;

        public PartialStructFieldCollectionWithCodeAnalysis(StructFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<StructConstantWithCodeAnalysis, PartialStructConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new PartialStructConstantWithCodeAnalysis(parent),
                child => child.Constant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<StructFieldWithCodeAnalysis, PartialStructFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new PartialStructFieldWithCodeAnalysis(parent),
                child => child.Field,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<PartialStructConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<PartialStructFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
