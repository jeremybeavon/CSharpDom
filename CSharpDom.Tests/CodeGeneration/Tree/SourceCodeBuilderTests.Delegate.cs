using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string))
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate string TestDelegate();";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        Visibility = TypeVisibilityModifier.Public,
                        ReturnType = new TypeReference(typeof(string))
                    }
                }
            }).Accept(builder);
            const string expectedText = @"public delegate string TestDelegate();";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        Visibility = TypeVisibilityModifier.Internal,
                        ReturnType = new TypeReference(typeof(string))
                    }
                }
            }).Accept(builder);
            const string expectedText = @"internal delegate string TestDelegate();";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestDelegateWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate string TestDelegate<T>();";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate string TestDelegate<TKey, TValue>();";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : class;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : struct;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : new();";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : BaseClass;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : ITestInterface;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : ITestInterface, ITestInterface2;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<TParent, TChild>()
    where TChild : TParent;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<TGrandparent, TParent, TChild>()
    where TChild : TGrandparent, TParent;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : class, ITestInterface, new();";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string)),
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
            const string expectedText = @"delegate string TestDelegate<TKey, TValue>()
    where TKey : ITestInterface
    where TValue : TKey;";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(void)),
                        Parameters = new CodeGenerationCollection<DelegateParameter>()
                        {
                            new DelegateParameter("parameter1")
                            {
                                Type = new TypeReference(typeof(string))
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate void TestDelegate(string parameter1);";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithOutParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(void)),
                        Parameters = new CodeGenerationCollection<DelegateParameter>()
                        {
                            new DelegateParameter("parameter1")
                            {
                                Modifier = DelegateParameterModifier.Out,
                                Type = new TypeReference(typeof(string))
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate void TestDelegate(out string parameter1);";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithRefParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(void)),
                        Parameters = new CodeGenerationCollection<DelegateParameter>()
                        {
                            new DelegateParameter("parameter1")
                            {
                                Modifier = DelegateParameterModifier.Ref,
                                Type = new TypeReference(typeof(string))
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate void TestDelegate(ref string parameter1);";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithParamsParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(void)),
                        Parameters = new CodeGenerationCollection<DelegateParameter>()
                        {
                            new DelegateParameter("parameter1")
                            {
                                Modifier = DelegateParameterModifier.Params,
                                Type = new TypeReference("string[]")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"delegate void TestDelegate(params string[] parameter1);";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
