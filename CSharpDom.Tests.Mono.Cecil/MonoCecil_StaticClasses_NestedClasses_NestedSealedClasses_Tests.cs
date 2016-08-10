using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_NestedSealedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWith1GenericParameterUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWith2GenericParametersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithBaseClassUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedSealedClassUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedSealedClassUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedSealedClassUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedSealedClassUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedSealedClassUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedSealedClass));
        }
    }
}
