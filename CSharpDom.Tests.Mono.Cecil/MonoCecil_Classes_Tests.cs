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
            TestClass(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWith1GenericParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWith2GenericParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClass(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithBaseClassUsingMonoCecil()
        {
            TestClass(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalClassUsingMonoCecil()
        {
            TestClass(typeof(InternalClass));
        }

        [TestMethod]
        public void TestPublicClassUsingMonoCecil()
        {
            TestClass(typeof(PublicClass));
        }
    }
}
