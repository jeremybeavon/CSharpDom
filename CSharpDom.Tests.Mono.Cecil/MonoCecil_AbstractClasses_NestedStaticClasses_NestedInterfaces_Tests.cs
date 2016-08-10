using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalNestedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateNestedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedNestedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
