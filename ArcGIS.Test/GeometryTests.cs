﻿using ArcGIS.ServiceModel.Common;
using Xunit;

namespace ArcGIS.Test
{
    public class GeometryTests
    {
        [Fact]
        public void FeaturesAreTheSame()
        {
            var feature1 = new Feature<Point>
            {
                Geometry = new Point { X = 50.342, Y = -30.331, SpatialReference = SpatialReference.WGS84 }
            };
            feature1.Attributes.Add("random", "rtcxbvbx");
            feature1.Attributes.Add("something", 45445);

            var feature2 = new Feature<Point>
            {
                Geometry = new Point { X = 50.342, Y = -30.331, SpatialReference = SpatialReference.WGS84 }
            };
            feature2.Attributes.Add("random", "rtcxbvbx");
            feature2.Attributes.Add("something", 45445);

            Assert.Equal(feature1, feature2);
        }

        [Fact]
        public void FeaturesAreNotTheSame()
        {
            var feature1 = new Feature<Point>
            {
                Geometry = new Point { X = 50.342, Y = -2, SpatialReference = SpatialReference.WGS84 }
            };

            var feature2 = new Feature<Point>
            {
                Geometry = new Point { X = 50.342, Y = -30.331, SpatialReference = SpatialReference.WGS84 }
            };

            var feature3 = new Feature<Point>
            {
                Geometry = new Point { X = 50.342, Y = -30.331, SpatialReference = SpatialReference.WGS84 }
            };
            feature3.Attributes.Add("random", "rtcxbvbx");
            feature3.Attributes.Add("something", 45445);

            var feature4 = new Feature<Point>
            {
                Geometry = new Point { X = 50.342, Y = -30.331, SpatialReference = SpatialReference.WGS84 }
            };
            feature4.Attributes.Add("random", "rtcxbvbx");
            feature4.Attributes.Add("something", 4);

            Assert.NotEqual(feature1, feature2);
            Assert.NotEqual(feature3, feature4);
            Assert.NotEqual(feature1, feature3);
            Assert.NotEqual(feature1, feature4);
            Assert.NotEqual(feature2, feature3);
            Assert.NotEqual(feature2, feature4);
        }

        [Fact]
        public void SpatialReferencesAreTheSame()
        {
            var sr = new SpatialReference { Wkid = SpatialReference.WGS84.Wkid };
            Assert.Equal(sr, SpatialReference.WGS84);

            var sr2 = new SpatialReference { Wkid = SpatialReference.WGS84.LatestWkid };
            Assert.Equal(sr2, SpatialReference.WGS84);

            var sr3 = SpatialReference.WGS84;
            Assert.Equal(sr3, SpatialReference.WGS84);

            Assert.True(sr == sr2);
            Assert.True(sr == sr3);
            Assert.True(sr3 == sr2);
            Assert.False(SpatialReference.WGS84 == null);
            Assert.False(null == SpatialReference.WGS84);
            Assert.False(new SpatialReference { Wkid = 2193 } == SpatialReference.WGS84);
        }

        [Fact]
        public void SpatialReferencesAreNotTheSame()
        {
            var sr = new SpatialReference { Wkid = SpatialReference.WebMercator.Wkid };
            Assert.NotEqual(sr, SpatialReference.WGS84);

            var sr2 = SpatialReference.WebMercator;
            Assert.NotEqual(sr2, SpatialReference.WGS84);

            Assert.True(SpatialReference.WGS84 != SpatialReference.WebMercator);
            Assert.False(SpatialReference.WGS84 == SpatialReference.WebMercator);

            Assert.True(sr != SpatialReference.WGS84);
            Assert.True(SpatialReference.WebMercator != SpatialReference.WGS84);

            Assert.True(SpatialReference.WGS84 != null);
            Assert.True(null != SpatialReference.WGS84);
            Assert.True(new SpatialReference { Wkid = 2193 } != SpatialReference.WGS84);
        }
    }
}
