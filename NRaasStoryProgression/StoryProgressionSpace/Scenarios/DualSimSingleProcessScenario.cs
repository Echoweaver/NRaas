﻿using NRaas.StoryProgressionSpace.Careers;
using NRaas.StoryProgressionSpace.Managers;
using NRaas.StoryProgressionSpace.Helpers;
using NRaas.CommonSpace.ScoringMethods;
using NRaas.StoryProgressionSpace.Scenarios.Money;
using NRaas.StoryProgressionSpace.Scoring;
using NRaas.StoryProgressionSpace.SimDataElement;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.Careers;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.ObjectComponents;
using Sims3.Gameplay.Objects;
using Sims3.Gameplay.Objects.Appliances;
using Sims3.Gameplay.Objects.HobbiesSkills;
using Sims3.Gameplay.Objects.Miscellaneous;
using Sims3.Gameplay.Objects.Plumbing;
using Sims3.Gameplay.Skills;
using Sims3.Gameplay.TuningValues;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.SimIFace.CAS;
using Sims3.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.StoryProgressionSpace.Scenarios
{
    public abstract class DualSimSingleProcessScenario : DualSimScenario
    {
        Dictionary<ulong, bool> mProcessed = new Dictionary<ulong, bool>();

        public DualSimSingleProcessScenario()
        { }
        protected DualSimSingleProcessScenario(DualSimSingleProcessScenario scenario)
            : base (scenario)
        {
            mProcessed = scenario.mProcessed;
        }

        protected override bool CheckBusy
        {
            get { return true; }
        }

        protected override bool Progressed
        {
            get { return true; }
        }

        protected override int Rescheduling
        {
            get { return 120; }
        }

        protected override int MaximumReschedules
        {
            get { return 2; }
        }

        protected override bool AlwaysReschedule
        {
            get { return true; }
        }

        protected override bool Allow(SimDescription sim)
        {
            if (mProcessed.ContainsKey(sim.SimDescriptionId))
            {
                IncStat("Already Processed");
                return false;
            }

            return base.Allow(sim);
        }

        protected override bool PrivateUpdate(ScenarioFrame frame)
        {
            if (mProcessed.ContainsKey(Sim.SimDescriptionId))
            {
                mProcessed.Add(Sim.SimDescriptionId, true);
            }

            return false;
        }
    }
}
