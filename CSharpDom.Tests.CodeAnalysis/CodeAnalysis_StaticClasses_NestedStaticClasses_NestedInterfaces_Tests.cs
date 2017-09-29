using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalNestedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateNestedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedNestedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedInternalNestedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicNestedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
