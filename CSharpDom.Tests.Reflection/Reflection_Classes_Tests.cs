using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithBaseClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalClassUsingReflection()
        {
            TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public void TestPublicClassUsingReflection()
        {
            TestClassAsync(typeof(PublicClass));
        }
    }
}
