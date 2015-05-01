﻿// Accord Unit Tests
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Tests.Math
{
    using Accord.Math;
    using NUnit.Framework;
    using AForge.Math;

    [TestFixture]
    public class CosineTransformTest
    {


        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }




        [Test]
        public void ForwardTest()
        {
            double[,] input = 
            {
                { 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.862745098039216, 0, 0.662745098039216, 0.996078431372549, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.529411764705882, 0.129411764705882, 0.262745098039216, 0.996078431372549, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.0627450980392157, 0.662745098039216, 0.0627450980392157, 0.862745098039216, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.662745098039216, 0, 0, 0, 0.529411764705882, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.262745098039216, 0.529411764705882, 0.996078431372549, 0.729411764705882, 0.0627450980392157, 0.996078431372549, 0.996078431372549 },
                { 0.862745098039216, 0, 0.929411764705882, 0.996078431372549, 0.996078431372549, 0.129411764705882, 0.662745098039216, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549 }
            };

            CosineTransform.DCT(input);

            double[,] actual = input;

            double[,] expected =
            {
                {  6.1917, -0.3411,  1.2418,  0.1492,  0.1583,  0.2742 ,  -0.0724  ,  0.0561 },
                {  0.2205,  0.0214,  0.4503,  0.3947, -0.7846, -0.4391  ,  0.1001  , -0.2554 },
                {  1.0423,  0.2214, -1.0017, -0.2720,  0.0789, -0.1952  ,  0.2801  ,  0.4713  },
                { -0.2340, -0.0392, -0.2617, -0.2866,  0.6351,  0.3501 ,  -0.1433  ,  0.3550  },
                {  0.2750,  0.0226,  0.1229,  0.2183, -0.2583, -0.0742  , -0.2042  , -0.5906  },
                {  0.0653,  0.0428, -0.4721, -0.2905,  0.4745,  0.2875  , -0.0284  , -0.1311  },
                {  0.3169,  0.0541, -0.1033, -0.0225, -0.0056,  0.1017  , -0.1650 ,  -0.1500  },
                { -0.2970, -0.0627,  0.1960,  0.0644, -0.1136, -0.1031 ,   0.1887  ,  0.1444  },
            };

            Assert.IsTrue(actual.IsEqual(expected, 0.05));
        }

        [Test]
        public void InverseTest()
        {
            double[,] input =
            {
                {  6.1917, -0.3411,  1.2418,  0.1492,  0.1583,  0.2742 ,  -0.0724  ,  0.0561 },
                {  0.2205,  0.0214,  0.4503,  0.3947, -0.7846, -0.4391  ,  0.1001  , -0.2554 },
                {  1.0423,  0.2214, -1.0017, -0.2720,  0.0789, -0.1952  ,  0.2801  ,  0.4713  },
                { -0.2340, -0.0392, -0.2617, -0.2866,  0.6351,  0.3501 ,  -0.1433  ,  0.3550  },
                {  0.2750,  0.0226,  0.1229,  0.2183, -0.2583, -0.0742  , -0.2042  , -0.5906  },
                {  0.0653,  0.0428, -0.4721, -0.2905,  0.4745,  0.2875  , -0.0284  , -0.1311  },
                {  0.3169,  0.0541, -0.1033, -0.0225, -0.0056,  0.1017  , -0.1650 ,  -0.1500  },
                { -0.2970, -0.0627,  0.1960,  0.0644, -0.1136, -0.1031 ,   0.1887  ,  0.1444  },
            };

            CosineTransform.IDCT(input);

            double[,] actual = input;

            double[,] expected = 
            {
                { 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.862745098039216, 0, 0.662745098039216, 0.996078431372549, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.529411764705882, 0.129411764705882, 0.262745098039216, 0.996078431372549, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.0627450980392157, 0.662745098039216, 0.0627450980392157, 0.862745098039216, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.662745098039216, 0, 0, 0, 0.529411764705882, 0.996078431372549, 0.996078431372549 },
                { 0.996078431372549, 0.262745098039216, 0.529411764705882, 0.996078431372549, 0.729411764705882, 0.0627450980392157, 0.996078431372549, 0.996078431372549 },
                { 0.862745098039216, 0, 0.929411764705882, 0.996078431372549, 0.996078431372549, 0.129411764705882, 0.662745098039216, 0.996078431372549 },
                { 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549, 0.996078431372549 }
            };

            Assert.IsTrue(actual.IsEqual(expected, 0.05));
        }
    }
}
