using CSharpDom.TestTarget.Classes.NestedStructs.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_NestedInterfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedInterface));
        }
    }
}
