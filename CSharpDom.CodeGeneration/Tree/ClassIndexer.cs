namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassIndexer : CodeGenerationNode
    {
        private EmptyClassPropertyAccessors emptyAccessors;
        private ClassPropertyAccessor getAccessor;
        private ClassPropertyAccessor setAccessor;

        public ClassIndexer()
        {
            Parameters = new CodeGenerationCollection<MethodParameter>();
        }
        
        public ClassMemberVisibilityModifier Visibility { get; set; }

        public IndexerInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

        public CodeGenerationCollection<MethodParameter> Parameters { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors
        {
            get
            {
                return emptyAccessors;
            }

            set
            {
                emptyAccessors = value;
                if (value != null)
                {
                    getAccessor = null;
                    setAccessor = null;
                }
            }
        }

        public ClassPropertyAccessor GetAccessor
        {
            get
            {
                return getAccessor;
            }

            set
            {
                getAccessor = value;
                if (value != null)
                {
                    emptyAccessors = null;
                }
            }
        }

        public ClassPropertyAccessor SetAccessor
        {
            get
            {
                return setAccessor;
            }

            set
            {
                setAccessor = value;
                if (value != null)
                {
                    emptyAccessors = null;
                }
            }
        }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
            Parameters.AcceptIfNotNull(visitor);
            EmptyAccessors.AcceptIfNotNull(visitor);
            GetAccessor.AcceptIfNotNull(visitor);
            SetAccessor.AcceptIfNotNull(visitor);
        }
    }
}
