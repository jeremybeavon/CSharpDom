using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                }
            }).Accept(builder);
            const string expectedText = @"interface TestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).Accept(builder);
            const string expectedText = @"public interface TestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).Accept(builder);
            const string expectedText = @"internal interface TestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<TKey, TValue>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : class
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : struct
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : BaseClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<TParent, TChild>
    where TChild : TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<T>
    where T : class, ITestInterface, new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
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
            }).Accept(builder);
            const string expectedText = @"interface TestInterface<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestInterfaceWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"interface TestInterface : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2Interfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface"),
                            new InterfaceReference("ITestInterface2")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"interface TestInterface : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("TestInterface")
                    {
                        IsPartial = true
                    }
                }
            }).Accept(builder);
            const string expectedText = @"partial interface TestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
