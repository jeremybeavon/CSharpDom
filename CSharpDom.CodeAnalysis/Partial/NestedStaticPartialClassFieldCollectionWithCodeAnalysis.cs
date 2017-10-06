using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassFieldCollectionWithCodeAnalysis :
        EditableStaticClassFieldCollection<
            NestedStaticPartialClassFieldWithCodeAnalysis,
            NestedStaticPartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            NestedStaticClassConstantWithCodeAnalysis,
            NestedStaticPartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<
            NestedStaticClassFieldWithCodeAnalysis,
            NestedStaticPartialClassFieldWithCodeAnalysis> fields;

        public NestedStaticPartialClassFieldCollectionWithCodeAnalysis(
            NestedStaticClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<NestedStaticClassConstantWithCodeAnalysis, NestedStaticPartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new NestedStaticPartialClassConstantWithCodeAnalysis(parent),
                child => child.Constant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<NestedStaticClassFieldWithCodeAnalysis, NestedStaticPartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new NestedStaticPartialClassFieldWithCodeAnalysis(parent),
                child => child.Field,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<NestedStaticPartialClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<NestedStaticPartialClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
