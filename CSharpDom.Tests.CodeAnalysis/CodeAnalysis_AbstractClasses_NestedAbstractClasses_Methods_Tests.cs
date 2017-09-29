using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
