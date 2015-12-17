using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassNestedDelegate()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedDelegate()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public delegate string TestClassNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedDelegate()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal delegate string TestClassNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedDelegate()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal delegate string TestClassNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedDelegate()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected delegate string TestClassNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedDelegate()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private delegate string TestClassNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith1GenericParameter()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
    delegate string TestClassNestedDelegate<T>();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2GenericParameters()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
    delegate string TestClassNestedDelegate<TKey, TValue>();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithClassGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : class;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithStructGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : struct;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithEmptyConstructorGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : new();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithBaseClassGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : BaseClass;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith1InterfaceGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : ITestInterface;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2InterfaceGenericParameterConstraints()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : ITestInterface, ITestInterface2;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith1GenericTypeGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TParent, TChild>()
        where TChild : TParent;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2GenericTypeGenericParameterConstraint()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : class, ITestInterface, new();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2GenericParameterConstraints()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithParameter()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string))
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
    delegate void TestClassNestedDelegate(string parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithOutParameter()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Out,
                                            Type = new TypeReference(typeof(string))
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
    delegate void TestClassNestedDelegate(out string parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithRefParameter()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Ref,
                                            Type = new TypeReference(typeof(string))
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
    delegate void TestClassNestedDelegate(ref string parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithParamsParameter()
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
                            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Params,
                                            Type = new TypeReference("string[]")
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
    delegate void TestClassNestedDelegate(params string[] parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
