using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalNestedStructUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateNestedStructUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedNestedStructUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedStructUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicNestedStructUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedStruct));
        }
    }
}
