using CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualMethod));
        }
    }
}
