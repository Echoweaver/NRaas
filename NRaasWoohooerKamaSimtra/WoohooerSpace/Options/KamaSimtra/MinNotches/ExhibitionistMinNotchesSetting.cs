﻿using NRaas.CommonSpace.Options;
using NRaas.WoohooerSpace.Skills;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.WoohooerSpace.Options.KamaSimtra.MinNotches
{
    public class ExhibitionistMinNotchesSetting : IntegerSettingOption<GameObject>, IMinNotchesOption
    {
        protected override int Value
        {
            get
            {
                return Skills.KamaSimtra.Settings.mExhibitionistMinNotches;
            }
            set
            {
                Skills.KamaSimtra.Settings.mExhibitionistMinNotches = value;
            }
        }

        public override string GetTitlePrefix()
        {
            return "ExhibitionistMinNotches";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new ListingOption(); }
        }
    }
}
