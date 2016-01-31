using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassNestedDelegate()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedDelegate()
        {
            const string expectedText = @"class TestClass
{
    public delegate string TestClassNestedDelegate();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedDelegate()
        {
            const string expectedText = @"class TestClass
{
    internal delegate string TestClassNestedDelegate();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedDelegate()
        {
            const string expectedText = @"class TestClass
{
    protected internal delegate string TestClassNestedDelegate();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedDelegate()
        {
            const string expectedText = @"class TestClass
{
    protected delegate string TestClassNestedDelegate();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedDelegate()
        {
            const string expectedText = @"class TestClass
{
    private delegate string TestClassNestedDelegate();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith1GenericParameter()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2GenericParameters()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TKey, TValue>();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : class;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Class
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithStructGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : struct;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Struct
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : new();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : BaseClass;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : ITestInterface;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : ITestInterface, ITestInterface2;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TParent, TChild>()
        where TChild : TParent;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<T>()
        where T : class, ITestInterface, new();
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Class,
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWith2GenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    delegate string TestClassNestedDelegate<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey;
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithParameter()
        {
            const string expectedText = @"class TestClass
{
    delegate void TestClassNestedDelegate(string parameter1);
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithOutParameter()
        {
            const string expectedText = @"class TestClass
{
    delegate void TestClassNestedDelegate(out string parameter1);
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithRefParameter()
        {
            const string expectedText = @"class TestClass
{
    delegate void TestClassNestedDelegate(ref string parameter1);
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedDelegateWithParamsParameter()
        {
            const string expectedText = @"class TestClass
{
    delegate void TestClassNestedDelegate(params string[] parameter1);
}";
            (new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedDelegates = new Collection<ClassNestedDelegate>()
                            {
                                new ClassNestedDelegate("TestClassNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
