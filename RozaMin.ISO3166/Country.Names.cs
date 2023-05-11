using RozaMin.ISO3166.Consts;
using System;
using System.Linq;

namespace RozaMin.ISO3166
{
    public partial class Country
    {
        public static Country Afghanistan
        {
            get
            {
                return All.Single(x => x.TwoLetterCode == TwoLetterCodes.Afghanistan);
            }
        }

        public static Country Zimbabwe
        {
            get
            {
                return All.Single(x => x.TwoLetterCode == TwoLetterCodes.Zimbabwe);
            }
        }

        public static Country UnitedKingdomOfGreatBritainAndNorthernIreland
        {
            get
            {
                return All.Single(x => x.TwoLetterCode == TwoLetterCodes.UnitedKingdomOfGreatBritainAndNorthernIreland);
            }
        }

        public static Country Iran
        {
            get
            {
                return All.Single(x => x.TwoLetterCode == TwoLetterCodes.Iran);
            }
        }

        public static Country Iraq
        {
            get
            {
                return All.Single(x => x.TwoLetterCode == TwoLetterCodes.Iraq);
            }
        }
    }
}
