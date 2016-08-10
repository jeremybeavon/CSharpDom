using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithBaseClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalClassUsingMonoCecil()
        {
            TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public void TestPublicClassUsingMonoCecil()
        {
            TestClassAsync(typeof(PublicClass));
        }
    }
}
