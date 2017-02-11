using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWith1GenericParameterUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWith1ImplementedInterface));
        }
        
        [TestMethod]
        public void TestAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWith2GenericParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithBaseClassUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalAbstractClassUsingReflection()
        {
            TestAbstractClass(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public void TestPublicAbstractClassUsingReflection()
        {
            TestAbstractClass(typeof(PublicAbstractClass));
        }
    }
}
