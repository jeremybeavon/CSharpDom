namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassProperty : CodeGenerationNode
    {
        private EmptyClassPropertyAccessors emptyAccessors;
        private ClassPropertyAccessor getAccessor;
        private ClassPropertyAccessor setAccessor;

        public ClassProperty(string name)
        {
            Name = name;
            emptyAccessors = new EmptyClassPropertyAccessors();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

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
            EmptyAccessors.AcceptIfNotNull(visitor);
            GetAccessor.AcceptIfNotNull(visitor);
            SetAccessor.AcceptIfNotNull(visitor);
        }
    }
}
