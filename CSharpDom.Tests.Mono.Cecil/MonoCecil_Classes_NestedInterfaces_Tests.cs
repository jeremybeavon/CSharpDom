using CSharpDom.TestTarget.Classes.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithInternalNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicNestedInterface));
        }
    }
}
