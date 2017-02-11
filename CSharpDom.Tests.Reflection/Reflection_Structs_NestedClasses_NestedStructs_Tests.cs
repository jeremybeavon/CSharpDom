using CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedStructUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedStructUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedStructUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedStructUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedStructUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicNestedStruct));
        }
    }
}
