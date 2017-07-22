using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<AbstractPartialClassFieldWithCodeAnalysis, AbstractPartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            AbstractClassConstantWithCodeAnalysis,
            AbstractPartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<AbstractClassFieldWithCodeAnalysis, AbstractPartialClassFieldWithCodeAnalysis> fields;

        public AbstractPartialClassFieldCollectionWithCodeAnalysis(AbstractClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<AbstractClassConstantWithCodeAnalysis, AbstractPartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new AbstractPartialClassConstantWithCodeAnalysis(parent),
                child => child.Constant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<AbstractClassFieldWithCodeAnalysis, AbstractPartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new AbstractPartialClassFieldWithCodeAnalysis(parent),
                child => child.Field,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<AbstractPartialClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<AbstractPartialClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
