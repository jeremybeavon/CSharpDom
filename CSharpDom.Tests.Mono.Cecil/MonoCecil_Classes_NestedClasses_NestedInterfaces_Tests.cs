using CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedInterface));
        }
    }
}
