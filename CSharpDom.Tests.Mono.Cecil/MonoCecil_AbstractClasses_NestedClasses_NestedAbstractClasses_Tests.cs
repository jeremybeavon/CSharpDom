using CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicNestedAbstractClass));
        }
    }
}
