using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedCheck;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedCheck.Tests
{
    [TestClass()]
    public class SpeedMeasurementCatalogTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddSpeedMeasurementTest301()
        {
            SpeedMeasurementCatalog sc = new SpeedMeasurementCatalog("Maglegårdvej 2, 4000", "by", 50);
            sc.AddSpeedMeasurement(301);
            
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddSpeedMeasurementTestnega1()
        {
            SpeedMeasurementCatalog sc = new SpeedMeasurementCatalog("Maglegårdvej 2, 4000", "by", 50);
            sc.AddSpeedMeasurement(-1);

        }

        [TestMethod()]
        public void AddSpeedMeasurementTest0()
        {
            SpeedMeasurementCatalog sc = new SpeedMeasurementCatalog("Maglegårdvej 2, 4000", "by", 50);
            sc.AddSpeedMeasurement(0);
            Assert.AreEqual(0, sc._speedList[0].Speed);

        }
        [TestMethod()]
        public void AddSpeedMeasurementTest300()
        {
            SpeedMeasurementCatalog sc = new SpeedMeasurementCatalog("Maglegårdvej 2, 4000", "by", 50);
            sc.AddSpeedMeasurement(300);
            Assert.AreEqual(300, sc._speedList[0].Speed);

        }
    }
}