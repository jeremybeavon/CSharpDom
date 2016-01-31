using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestDelegate()
        {
            const string expectedText = @"delegate string TestDelegate();";             
(new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
                    {
                        ReturnType = new TypeReference(typeof(string))
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicDelegate()
        {
            const string expectedText = @"public delegate string TestDelegate();";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalDelegate()
        {
            const string expectedText = @"internal delegate string TestDelegate();";             
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestDelegateWith1GenericParameter()
        {
            const string expectedText = @"delegate string TestDelegate<T>();";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2GenericParameters()
        {
            const string expectedText = @"delegate string TestDelegate<TKey, TValue>();";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithClassGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : class;";             
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
                                TypeConstraint = GenericParameterTypeConstraint.Class
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithStructGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : struct;";             
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
                                TypeConstraint = GenericParameterTypeConstraint.Struct
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : new();";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : BaseClass;";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : ITestInterface;";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : ITestInterface, ITestInterface2;";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<TParent, TChild>()
    where TChild : TParent;";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"delegate string TestDelegate<TGrandparent, TParent, TChild>()
    where TChild : TGrandparent, TParent;";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"delegate string TestDelegate<T>()
    where T : class, ITestInterface, new();";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWith2GenericParameterConstraints()
        {
            const string expectedText = @"delegate string TestDelegate<TKey, TValue>()
    where TKey : ITestInterface
    where TValue : TKey;";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithParameter()
        {
            const string expectedText = @"delegate void TestDelegate(string parameter1);";             
(new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithOutParameter()
        {
            const string expectedText = @"delegate void TestDelegate(out string parameter1);";             
(new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithRefParameter()
        {
            const string expectedText = @"delegate void TestDelegate(ref string parameter1);";             
(new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestDelegateWithParamsParameter()
        {
            const string expectedText = @"delegate void TestDelegate(params string[] parameter1);";             
(new CodeGenerationFile()
            {
                Delegates =
                {
                    new Delegate("TestDelegate")
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
