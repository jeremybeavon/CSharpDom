using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<AbstractPartialClassFieldWithCodeAnalysis, AbstractPartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassConstantWithCodeAnalysis,
            AbstractPartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<ClassFieldWithCodeAnalysis, AbstractPartialClassFieldWithCodeAnalysis> fields;

        public AbstractPartialClassFieldCollectionWithCodeAnalysis(ClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<ClassConstantWithCodeAnalysis, AbstractPartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new AbstractPartialClassConstantWithCodeAnalysis(parent),
                child => child.InternalConstant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<ClassFieldWithCodeAnalysis, AbstractPartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new AbstractPartialClassFieldWithCodeAnalysis(parent),
                child => child.InternalField,
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
