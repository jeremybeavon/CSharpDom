using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string this[string parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Indexers()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                },
                                new ClassIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string this[string parameter1]
    {
        set { }
    }

    string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestClassWithPublicAbstractIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.Abstract,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public abstract string this[int parameter1] { set; }
}";
            builder.ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithPublicNewIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.New,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestClassWithPublicNewVirtualIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.NewVirtual,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new virtual string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.Override,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public override string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.SealedOverride,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public sealed override string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualIndexer()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new CodeGenerationCollection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.Virtual,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public virtual string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
