﻿using NRaas.StoryProgressionSpace.Interfaces;
using NRaas.StoryProgressionSpace.Managers;
using NRaas.CommonSpace.ScoringMethods;
using NRaas.StoryProgressionSpace.Options;
using NRaas.StoryProgressionSpace.Personalities;
using NRaas.StoryProgressionSpace.Scenarios.Sims;
using NRaas.StoryProgressionSpace.Scoring;
using NRaas.StoryProgressionSpace.SimDataElement;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.EventSystem;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Objects;
using Sims3.Gameplay.Socializing;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.SimIFace.CAS;
using Sims3.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.StoryProgressionSpace.Scenarios.Sims
{
    public abstract class ResetSimDataScenario<T> : SimUpdateScenario
        where T : OnDemandSimData, new()
    {
        public ResetSimDataScenario()
        { }
        protected ResetSimDataScenario(ResetSimDataScenario<T> scenario)
            : base (scenario)
        { }

        protected override bool ContinuousUpdate
        {
            get { return false; }
        }

        protected override void PrivatePerform(SimDescription sim, SimData data, ScenarioFrame frame)
        {
            data.Get<T>().Reset();
        }
    }
}
