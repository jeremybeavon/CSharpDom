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
            TestClass(typeof(ClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithInternalNestedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicNestedInterface));
        }
    }
}
