using CSharpDom.TestTarget.Classes.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualMethod));
        }
    }
}
