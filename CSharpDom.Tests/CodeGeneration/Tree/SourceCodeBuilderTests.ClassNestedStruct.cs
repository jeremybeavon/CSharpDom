using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TKey"),
                                        new GenericParameter("TValue")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TKey, TValue>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Class
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Struct
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            HasEmptyConstructorConstraint = true
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            BaseClassConstraint = new ClassReference("BaseClass")
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints =
                                            {
                                                new InterfaceReference("ITestInterface")
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints =
                                            {
                                                new InterfaceReference("ITestInterface"),
                                                new InterfaceReference("ITestInterface2")
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TParent"),
                                        new GenericParameter("TChild")
                                        {
                                            GenericParameterConstraints =
                                            {
                                                new GenericParameterReference("TParent")
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TParent, TChild>
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TGrandparent"),
                                        new GenericParameter("TParent"),
                                        new GenericParameter("TChild")
                                        {
                                            GenericParameterConstraints =
                                            {
                                                new GenericParameterReference("TGrandparent"),
                                                new GenericParameterReference("TParent")
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Class,
                                            InterfaceConstraints =
                                            {
                                                new InterfaceReference("ITestInterface")
                                            },
                                            HasEmptyConstructorConstraint = true
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : class, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TKey")
                                        {
                                            InterfaceConstraints =
                                            {
                                                new InterfaceReference("ITestInterface")
                                            }
                                        },
                                        new GenericParameter("TValue")
                                        {
                                            GenericParameterConstraints =
                                            {
                                                new GenericParameterReference("TKey")
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestClassNestedStructWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith2Interfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface"),
                                        new InterfaceReference("ITestInterface2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialClassNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    partial struct TestClassNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
