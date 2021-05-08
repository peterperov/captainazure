using CaptainAzure.Logic;
using NUnit.Framework;
using System;

namespace CaptainAzure.Tests
{
    public class BullshitGenerator_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void BSGenerator_Init()
        {
            BullshitGenerator bs = new BullshitGenerator(); 
        }

        [Test]
        public void Generate_Success()
        {

            var i = 0;
            BullshitGenerator bs = new BullshitGenerator();

            while (i < 20)
            {
                Console.WriteLine(bs.Generate());
                i++; 
            }

        }

    }
}