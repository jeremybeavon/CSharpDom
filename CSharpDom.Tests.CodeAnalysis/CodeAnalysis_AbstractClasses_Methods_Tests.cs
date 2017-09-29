using CSharpDom.TestTarget.AbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualMethod));
        }
    }
}
