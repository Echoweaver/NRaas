﻿using NRaas.CommonSpace.Options;
using Sims3.Gameplay;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Controllers;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.EventSystem;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.MapTags;
using Sims3.Gameplay.Objects.Decorations;
using Sims3.Gameplay.Objects.HobbiesSkills;
using Sims3.Gameplay.Objects.RabbitHoles;
using Sims3.Gameplay.Skills;
using Sims3.Gameplay.Socializing;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.RelativitySpace.Options.Speeds.Interval
{
    public class Remove : OperationSettingOption<GameObject>, IIntervalOption
    {
        SpeedInterval mInterval;

        public Remove()
        { }
        public Remove(SpeedInterval interval)
        {
            mInterval = interval;
        }

        public override string GetTitlePrefix()
        {
            return "Remove";
        }

        protected override OptionResult Run(GameHitParameters<GameObject> parameters)
        {
            if (!AcceptCancelDialog.Show(Common.Localize(GetTitlePrefix() + ":Prompt")))
            {
                return OptionResult.SuccessRetain;
            }

            Relativity.Settings.Remove(mInterval);

            return OptionResult.SuccessLevelDown;
        }

        public IIntervalOption Clone(SpeedInterval interval)
        {
            return new Remove(interval);
        }
    }
}
