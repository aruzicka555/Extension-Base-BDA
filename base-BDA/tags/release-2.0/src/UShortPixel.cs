//  Copyright 2005 University of Wisconsin
//  Authors:  
//      Robert M. Scheller
//      James B. Domingo
//  BDA originally programmed by Wei (Vera) Li at University of Missouri-Columbia in 2004.
//  Version 1.0
//  License:  Available at  
//  http://landis.forest.wisc.edu/developers/LANDIS-IISourceCodeLicenseAgreement.pdf

using Landis.RasterIO;

namespace Landis.BDA
{
    public class UShortPixel
        : SingleBandPixel<ushort>
    {
        public UShortPixel()
            : base()
        {
        }

        //---------------------------------------------------------------------

        public UShortPixel(ushort band0)
            : base(band0)
        {
        }
    }
}
