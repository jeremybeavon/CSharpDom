using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassWithMethod()
        {
            const string expectedText = @"class TestClass
{
    void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicMethod()
        {
            const string expectedText = @"class TestClass
{
    public void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalMethod()
        {
            const string expectedText = @"class TestClass
{
    internal void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethod()
        {
            const string expectedText = @"class TestClass
{
    protected internal void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedMethod()
        {
            const string expectedText = @"class TestClass
{
    protected void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateMethod()
        {
            const string expectedText = @"class TestClass
{
    private void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestClassWithPublicAbstractMethod()
        {
            const string expectedText = @"class TestClass
{
    public abstract void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Abstract,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithPublicNewMethod()
        {
            const string expectedText = @"class TestClass
{
    public new void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.New,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewStaticMethod()
        {
            const string expectedText = @"class TestClass
{
    public new static void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewStatic,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewVirtualMethod()
        {
            const string expectedText = @"class TestClass
{
    public new virtual void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewVirtual,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideMethod()
        {
            const string expectedText = @"class TestClass
{
    public override void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Override,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideMethod()
        {
            const string expectedText = @"class TestClass
{
    public sealed override void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.SealedOverride,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticMethod()
        {
            const string expectedText = @"class TestClass
{
    public static void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Static,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualMethod()
        {
            const string expectedText = @"class TestClass
{
    public virtual void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Virtual,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestClassWithPublicVirtualAsyncMethod()
        {
            const string expectedText = @"class TestClass
{
    public virtual async void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Virtual,
                                    IsAsync = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        /*[TestMethod]
        public void TestClassWithPartialMethod()
        {
            const string expectedText = @"class TestClass
{
    partial void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        /*[TestMethod]
        public void TestClassWithAsyncPartialMethod()
        {
            const string expectedText = @"class TestClass
{
    async partial void Method1()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    IsAsync = true,
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithGenericMethod()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithGenericMethodWith2GenericParameters()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T1, T2>()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T1"),
                                        new GenericParameter("T2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWithClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithGenericMethodWithStructGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithGenericMethodWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithGenericMethodWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithGenericMethodWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new Collection<InterfaceReference>()
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
        public void TestClassWithGenericMethodWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new Collection<InterfaceReference>()
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
        public void TestClassWithGenericMethodWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    void Method1<TParent, TChild>()
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("TParent"),
                                        new GenericParameter("TChild")
                                        {
                                            GenericParameterConstraints = new Collection<GenericParameterReference>()
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
        public void TestClassWithGenericMethodWith2GenericTypeGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    void Method1<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithGenericMethodWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : class, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Class,
                                            InterfaceConstraints = new Collection<InterfaceReference>()
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
        public void TestClassWithGenericMethodWith2GenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    void Method1<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestClassWithMethodWithParameter()
        {
            const string expectedText = @"class TestClass
{
    void Method1(string parameter1)
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
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

        /*[TestMethod]
        public void TestClassWithMethodWithExtensionClassMethodParameter()
        {
            const string expectedText = @"static class TestClass
{
    static void Method1(this string parameter1)
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Static,
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    InheritanceModifier = ClassMemberInheritanceModifier.Static,
                                    Parameters = new Collection<ClassMethodParameter>()
                                    {
                                        new ClassMethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ClassMethodParameterModifier.This
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithMethodWithOutParameter()
        {
            const string expectedText = @"class TestClass
{
    void Method1(out string parameter1)
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ParameterModifier.Out
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
        public void TestClassWithMethodWithRefParameter()
        {
            const string expectedText = @"class TestClass
{
    void Method1(ref string parameter1)
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ParameterModifier.Ref
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
        public void TestClassWithMethodWithParamsParameter()
        {
            const string expectedText = @"class TestClass
{
    void Method1(params string[] parameter1)
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new Collection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference("string[]"),
                                            Modifier = ParameterModifier.Params
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
