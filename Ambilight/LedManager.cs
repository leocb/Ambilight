using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbilightController
{
    static class LedManager
    {

        public struct LedConfiguration
        {
            public decimal CountTop;
            public decimal CountRight;
            public decimal CountBottom;
            public decimal Countleft;
            public bool Clockwise;
            public decimal IndexOffset;
        }

        public struct LedColorSettings
        {
            public Color MixMultiplier;
            public int Brightness;
        }

        static private LedConfiguration LedPositions = new LedConfiguration();
        static private LedColorSettings ColorProfile = new LedColorSettings();

        static private int GetTotalLeds()
        {
            return (int)(LedPositions.CountTop + LedPositions.CountRight + LedPositions.CountBottom + LedPositions.Countleft);
        }

        static public void SetLedConfiguration(LedConfiguration LedPositionConfiguration, LedColorSettings LedColorConfiguration)
        {
            LedPositions = LedPositionConfiguration;
            ColorProfile = LedColorConfiguration;
        }

        static public void SetLedColor(int index, Color color)
        {

        }

        static public Byte[] GetLedDataArray()
        {
            int total = GetTotalLeds();
            Byte[] data = new Byte[total*3];



            return data;
        }
    }
}
